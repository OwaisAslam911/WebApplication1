namespace WebApplication1.Models
{
    public class AddPosition
    {
        public Position? Position { get; set; }
        public IEnumerable<Department>? departments { get; set; }

    }
}