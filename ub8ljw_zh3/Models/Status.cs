using System;
using System.Collections.Generic;

namespace ub8ljw_zh3.Models;

public partial class Status
{
    public byte StatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Instructor> Instructor { get; } = new List<Instructor>();
}
