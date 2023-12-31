﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgileAssistPro_IUSH.Models;

public partial class Usuarios
{
    [Key]
    public int Id { get; set; }

    public string Rol { get; set; } = null!;
    public string Nombre { get; set; } = null!;
    public string Correo { get; set; } = null!;
    public string IdCurso { get; set; } = null!;
    public string HoraInicio { get; set; } = null!;
    public int Asistencia { get; set; }
    public int Inasistencia { get; set; }
    public string HoraFin { get; set; } = null!;

}
