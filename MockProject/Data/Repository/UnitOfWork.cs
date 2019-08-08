using System;
using MockProject.Data.Interface;
using MockProject.Models;

namespace MockProject.Data.Repository
{
    public class UnitOfWork :IDisposable,IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        private Repository<User> _userRepository;
        private Repository<Faculty> _facultyRepository;
        private Repository<Subject> _subjectRepository;
        private Repository<Role> _roleRepository;
        private Repository<Semester> _semesterRepository;
        private Repository<Transcript> _transcriptRepository;
        private Repository<Schedule> _scheduleRepository;
        
        public IRepository<User> UserRepository => _userRepository ?? (_userRepository = new Repository<User>(_context));
        public IRepository<Faculty> FacultyRepository => _facultyRepository ?? (_facultyRepository = new Repository<Faculty>(_context));
        public IRepository<Subject> SubjectRepository => _subjectRepository ?? (_subjectRepository = new Repository<Subject>(_context));
        public IRepository<Role> RoleRepository => _roleRepository ?? (_roleRepository = new Repository<Role>(_context));
        public IRepository<Semester> SemesterRepository => _semesterRepository ?? (_semesterRepository = new Repository<Semester>(_context));
        public IRepository<Transcript> TranscriptRepository => _transcriptRepository ?? (_transcriptRepository = new Repository<Transcript>(_context));
        public IRepository<Schedule> ScheduleRepository => _scheduleRepository ?? (_scheduleRepository = new Repository<Schedule>(_context));
        
        
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool _disposed ;
 
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}