using Microsoft.AspNetCore.Mvc;
using prj29bWebCoreMVC.Models;
using prj29bWebCoreMVC.ViewModels;

namespace prj29bWebCoreMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public ViewResult Detail()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 929,
                Name = "Jen",
                Branch = "TO",
                Section = "A",
                Gender = "F"
            };
            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Hartford",
                State = "CT",
                Country = "USA",
                Zip = "100095"
            };
            //Creating the View model
            StudentDetailViewModel studentDetailViewModel = new StudentDetailViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details929",
            };
            //Pass the studentDetailsViewModel to the view
            return View(studentDetailViewModel);
        }
    }
}
