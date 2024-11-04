using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Views.Home;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Task1Context context;

        public HomeController(ILogger<HomeController> logger ,Task1Context context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var org = context.Organizations.ToList();
            return View(org);
        }
        public IActionResult AddOrg()
        {
   
            return View();
        }
        [HttpPost]
        public IActionResult AddOrg(Organization addorg)
        {
          
            Organization item = new Organization()
            {
                OrganizationName = addorg.OrganizationName,
                CompaneyEmail = addorg.CompaneyEmail,
                FoundedDate = addorg.FoundedDate,
                Phone =addorg.Phone,
                Location = addorg.Location
            };
            context.Organizations.Add(addorg);
            context.SaveChanges();
            return RedirectToAction("Index");
           
        }
        
        public IActionResult AddDept()
        {
            AddDept organization = new AddDept()
            {
                department = new Department(),
                organization = context.Organizations.ToList()
            };
            return View(organization);
        }

        [HttpPost]
      public IActionResult AddDept(Department addDepartment)
        {
            Department option = new Department()
            {
                DepartmentName = addDepartment.DepartmentName,
                Organization = addDepartment.Organization,
                
            };
            context.Departments.Add(option);
            context.SaveChanges();
            return RedirectToAction("DeptList");
            
        }

        public IActionResult DeptList()
        {
            var showdept = context.Departments.ToList();
            return View(showdept);
        }

        public IActionResult PositionList()
        {
         var showlist = context.Positions.ToList();
            return View(showlist);
           
        }
        public IActionResult AddPosition()
        {

            AddPosition post = new AddPosition()
            {
                Position = new Position(),
                departments = context.Departments.ToList()
            };
            return View(post);
        }
        [HttpPost]
        public IActionResult AddPosition(Position addpost)
        {
            Position position = new Position()
            {
                PositionTitle = addpost.PositionTitle,
                Department = addpost.Department
            };
            context.Positions.Add(addpost);
            context.SaveChanges();
            return RedirectToAction("PositionList");
      
        }

        public IActionResult Employeelist()
        {
            var emplist = context.Employees.ToList();
            return View(emplist);
        }

        public IActionResult AddEmployee()
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
