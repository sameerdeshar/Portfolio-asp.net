using Microsoft.AspNetCore.Mvc;
using Sameer.Models;
using System.Diagnostics;

namespace Sameer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var personalInfo = new PersonalInfoModel
            {
                Birthdate = "2058/02/20",
                Email = "sameerdeshar99@gmail.com",
                Phone = "9818197609",
                Skype = "Samir Deshar",
                Address = "Godawari-13, Lalitpur."
            };

    

   

            var skills = new List<SkillModel>
    {
        new SkillModel { SkillName = "HTML5 & CSS3", Percentage = 97 },
        new SkillModel { SkillName = "JavaScript", Percentage = 85 },
        // Add more skills
    };

            var projects = new List<ProjectModel>
    {
        new ProjectModel { Title = "Shoe_store", Description = "Ecommerce site of shoe store using nextjs and nodejs." },
        new ProjectModel { Title = "CRUD laravel app", Description = "CRUD app made using laravel." },
        // Add more projects
    };

            var viewModel = new AboutViewModel
            {
                PersonalInfo = personalInfo,
                Skills = skills,
                Projects = projects
            };

            return View(viewModel);
        }

        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}