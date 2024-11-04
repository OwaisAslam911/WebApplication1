using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Position
{
    public int PositionId { get; set; }

    public string? PositionTitle { get; set; }

    public int? DepartmentId { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
