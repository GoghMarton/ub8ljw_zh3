using System;
using System.Collections.Generic;

namespace ub8ljw_api.Models;

public partial class Instructor
{
    public int InstructorSk { get; set; }

    public string? Salutation { get; set; }

    public string Name { get; set; } = null!;

    public byte StatusId { get; set; }

    public string EmployementId { get; set; } = null!;
}
