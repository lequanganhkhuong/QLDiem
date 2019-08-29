using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MockProject.Data.Interface;
using MockProject.Models;
using MockProject.Models.ViewModels;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.ExpressionGraph.FunctionCompilers;

namespace MockProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _db;

        public UsersController(IUnitOfWork unitOfWork, IHostingEnvironment hostingEnvironment, AppDbContext context)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
            _db = context;
        }

        public IActionResult InfoUser(int? id)
        { 
            ViewBag.Pages = "User";
            var user =  _unitOfWork.UserRepository.Get(id);
            return View(user);
        }
        
        //generate code
        public IActionResult GenerateCode(int role)
        { 
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            
            var listCode = _unitOfWork.UserRepository.GetAll().Select(x => x.Code);
            
            string rs = "";

            do
            {
                string code = new string(Enumerable.Repeat(chars, 8)
                    .Select(s => s[random.Next(s.Length)]).ToArray());


                switch (role)
                {
                    case 1:
                        rs = "AD" + code;
                        break;
                    case 2:
                        rs = "GV" + code;
                        break;
                    case 3:
                        rs = "SV" + code;
                        break;
                }
            } while (listCode.Contains(rs));
            

            
           
            
            return Content(rs);
        }

        // GET: Users
        public async Task<IActionResult> Index( string filter)
        {
            ViewBag.Pages = "User";
           
            ViewBag.Filter = filter ?? "0";
            
            IQueryable<User> users = _unitOfWork.UserRepository.GetAll();
            if (!string.IsNullOrEmpty(filter))
            {
                int role = int.Parse(filter);
                if (role != 1 && role != 2 && role != 3 && role != 0)
                {
                    return View("NotFound");
                }
                if (role != 0)
                {
                    users = users.Where(x => x.RoleId == role);
                   
                }
                
            }
            
            return View(await users.Include(u => u.Faculty).Include(u => u.Role).ToListAsync());
        }

        // GET: Users/Details/5
        public  IActionResult Details(int? id)
        {
            ViewBag.Pages = "User";
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll().ToList(), "Name", "Name");
            if (id == null)
            {
                return NotFound();
            }

            var user =  _unitOfWork.UserRepository.Get(id);
           
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Pages = "User";
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name");
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name");
            ViewData["ClassesId"] = new SelectList(_unitOfWork.ClassRepository.GetAll().ToList(), "Id", "NameClass");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Id,Username,Password,Code,Name,Birthday,Address,Gender,IsActive,FacultyId,RoleId")] User user)
        {
            ViewBag.Pages = "User";
            
            //validate code
            if (user.Code.Length < 10)
            {
                return Content("Invalid code");
            }
            //check if code match the role
            var codeCheck = user.Code.Substring(0, 2);
            switch (user.RoleId)
            {
                case 1:
                    if (!codeCheck.Equals("AD")) return Content("Invalid admin code");
                    break;
                case 2:
                    if (!codeCheck.Equals("GV")) return Content("Invalid teacher code");
                    break;
                case 3:
                    if (!codeCheck.Equals("SV")) return Content("Invalid student code");
                    break;
            }
            //check if code existed
            var codeList = _unitOfWork.UserRepository.GetAll().Select(x => x.Code);
            if (codeList.Contains(user.Code)) return Content("This code already exists");
            
            
            
            if (ModelState.IsValid)
            {
                //PasswordHasher<User> hasher = new PasswordHasher<User>();
                //user.Password = hasher.HashPassword(user,user.Name);
                
                _unitOfWork.UserRepository.Insert(user);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name", user.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name", user.RoleId);
            ViewData["ClassesId"] = new SelectList(_unitOfWork.ClassRepository.GetAll().ToList(), "Id", "NameClass", user.ClassesId);


            return View(user);
        }

        // GET: Users/Edit/5
        public  IActionResult Edit(int? id)
        {
            ViewBag.Pages = "User";
            if (id == null)
            {
                return NotFound();
            }

            var user = _unitOfWork.UserRepository.Get(id);
            if (user == null)
            {
                return NotFound();
            }

            var userVm = new UsersEditVm
            {
                Id = user.Id,
                Address = user.Address,
                Birthday = user.Birthday,
                Code = user.Code,
                FacultyId = user.FacultyId,
                Gender = user.Gender,
                IsActive = user.IsActive,
                Name = user.Name,
                RoleId = user.RoleId
            };
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name", user.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name", user.RoleId);
            return View(userVm);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Code,Name,Birthday,Address,Gender,IsActive,FacultyId,RoleId")] UsersEditVm userVm)
        {
            ViewBag.Pages = "User";
            if (id != userVm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
//                    PasswordHasher<User> hasher = new PasswordHasher<User>();
//                    user.Password = hasher.HashPassword(user,user.Password);
                    var user = _unitOfWork.UserRepository.Get(userVm.Id);
                    if (user == null)
                    {
                        return NotFound();
                    }
                    user.Code = userVm.Code;
                    user.Name = userVm.Name;
                    user.Birthday = userVm.Birthday;
                    user.Address = userVm.Address;
                    user.Gender = userVm.Gender;
                    user.IsActive = userVm.IsActive;
                    user.FacultyId = userVm.FacultyId;
                    user.RoleId = userVm.RoleId;
                    _unitOfWork.UserRepository.Update(user);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacultyId"] = new SelectList(_unitOfWork.FacultyRepository.GetAll(filter:x => x.IsActive).ToList(), "Id", "Name", userVm.FacultyId);
            ViewData["RoleId"] = new SelectList(_unitOfWork.RoleRepository.GetAll().ToList(), "Id", "Name", userVm.RoleId);
            return View(userVm);
        }

        [HttpGet]
        public IActionResult IndexAddUserExcel()
        {
            ViewBag.Pages = "User";         
            return View();
        }
        public IActionResult ExportToExcel()
        {
            byte[] fileContents;
            List<UserListViewModel> emplist = _unitOfWork.UserRepository.GetAll().Include(x=>x.Faculty).Include(x=>x.Role).Select(x => new UserListViewModel
            {
                Name = x.Name,
                Address = x.Address,
                Gender = x.Gender,
                NameFaculty = x.Faculty.Name,
                NameRole = x.Role.Name
            }).ToList();

            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");


            ws.Cells["A1"].Value = "Name";
            ws.Cells["B1"].Value = "Address";
            ws.Cells["C1"].Value = "Gender";
            ws.Cells["D1"].Value = "Faculty";
            ws.Cells["E1"].Value = "Role";
    



            int rowStart = 2;
            foreach (var item in emplist)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.Name;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.Address;
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.Gender;
                ws.Cells[string.Format("D{0}", rowStart)].Value = item.NameFaculty;
                ws.Cells[string.Format("E{0}", rowStart)].Value = item.NameRole;
                rowStart++;
            }

            ws.Cells["A:AZ"].AutoFitColumns();
            fileContents = pck.GetAsByteArray();
            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: "ListUser.xlsx"
            );
        }

        public IActionResult Import()
        {
            ViewBag.Pages = "User";
            return View();
        }
        
        public string ImportUpload(IFormFile reportfile)
        {
            string folderName = "Upload";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            // Delete Files from Directory
            System.IO.DirectoryInfo di = new DirectoryInfo(newPath);
            foreach (FileInfo filesDelete in di.GetFiles())
            {
                filesDelete.Delete();
            }// End Deleting files form directories
 
            if (!Directory.Exists(newPath))// Crate New Directory if not exist as per the path
            {
                Directory.CreateDirectory(newPath);
            }
            var fiName = Guid.NewGuid().ToString() + Path.GetExtension(reportfile.FileName);
            using (var fileStream = new FileStream(Path.Combine(newPath, fiName), FileMode.Create))
            {
                reportfile.CopyTo(fileStream);
            }
            // Get uploaded file path with root
            string rootFolder = _hostingEnvironment.WebRootPath;
            string fileName = @"Upload/" + fiName;
            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));
            
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets["Report"];
                int totalRows = workSheet.Dimension.Rows;
                List<User> reportList = new List<User>();
                for (int i = 2; i <= totalRows; i++)
                {
                    try
                    {
                        string Username = workSheet?.Cells[i, 1]?.Value?.ToString();
                        string Name = workSheet?.Cells[i, 2]?.Value?.ToString(); 
                        string Address = workSheet?.Cells[i, 3]?.Value?.ToString(); 
                        string Gender =workSheet?.Cells[i, 4]?.Value?.ToString();
                        string IsActive = workSheet?.Cells[i, 5]?.Value?.ToString();
                        int FacultyId =Int32.Parse(workSheet?.Cells[i, 6]?.Value?.ToString());
                        int RoleId = Int32.Parse(workSheet?.Cells[i, 7]?.Value?.ToString());
                        reportList.Add(new User
                        {  
                            Username = Username,
                            Name = Name,
                            Address = Address,
                            Gender = Gender == "Male",
                            IsActive = IsActive == "1" ,
                            FacultyId = FacultyId,
                            RoleId = RoleId,
                        });
                     
                    }
                    catch (Exception Ex)
                    {
                        // Exception
                    }
                }
                _db.Users.AddRange(reportList);
                _db.SaveChanges();
                return "Uploaded";
            }
        }
        
    }
}
