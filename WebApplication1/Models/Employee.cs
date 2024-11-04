using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int? PositionId { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public int? OrganizationId { get; set; }

    public int? DepartmentId { get; set; }

    public string? Address { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public double? Salary { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Organization? Organization { get; set; }

    public virtual Position? Position { get; set; }
}
