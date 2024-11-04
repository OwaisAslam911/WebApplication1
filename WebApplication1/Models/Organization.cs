using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Organization
{
    public int OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public DateOnly? FoundedDate { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public string? CompaneyEmail { get; set; }

    public string? Phone { get; set; }

    public string? Location { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
