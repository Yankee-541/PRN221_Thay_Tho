using System;
using System.Collections.Generic;

namespace Topic1_WPF_Control.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? Gender { get; set; }

    public bool? Active { get; set; }

    public int? Country { get; set; }

    public virtual Country? CountryNavigation { get; set; }
}
