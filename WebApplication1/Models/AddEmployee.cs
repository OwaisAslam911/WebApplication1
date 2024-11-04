using WebApplication1.Models;

namespace WebApplication1.Views.Home
{
    public class AddEmployee
    {
        public Employee employee { get; set; }
        public IEnumerable<Position> post { get; set; }
        public IEnumerable<Department> dept { get; set; }
        public IEnumerable<Organization> org { get; set; }
    }
}
