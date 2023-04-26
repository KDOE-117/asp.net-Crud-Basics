using System;
using System.Collections.Generic;

namespace CRUD_MVC.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;
}
