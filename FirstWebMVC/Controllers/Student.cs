using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //lay tat ca sinh vien tu trong bang Students
            var students = await _context.Students.ToListAsync();
            //tra du lieu ve view
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            //them doi tuong std vao trong Db Context
            await _context.Students.AddAsync(std);
            //luu thay doi vao co so du lieu
            await _context.SaveChangesAsync();
            //dieu huong ve trang index khi xu ly thanh cong
            return RedirectToAction("Index");
        }
    }
}