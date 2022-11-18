using System;
using System.Collections.Generic;

namespace MVCEjercicio4.Models;

public partial class Area
{
    public long Id { get; set; }

    public string? Area1 { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
