using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public int? OrganizationId { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Organization? Organization { get; set; }

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}
