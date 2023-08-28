using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models;

public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Clave { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
