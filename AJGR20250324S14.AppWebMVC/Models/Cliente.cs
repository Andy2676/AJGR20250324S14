using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AJGR20250324S14.AppWebMVC.Models;

public partial class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "La dirección del cliente es obligatoria.")]
    [Display(Name = "Dirección")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = "El teléfono del cliente es obligatorio.")]
    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
