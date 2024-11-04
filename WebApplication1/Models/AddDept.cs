namespace WebApplication1.Models
{
    public class AddDept
    {
        public  Department? department { get; set; }
        public IEnumerable<Organization>? organization { get;   set; }
    }
}
