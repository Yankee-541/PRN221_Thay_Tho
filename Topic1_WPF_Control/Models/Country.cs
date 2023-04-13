using System;
using System.Collections.Generic;

namespace Topic1_WPF_Control.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Person> People { get; } = new List<Person>();
}
