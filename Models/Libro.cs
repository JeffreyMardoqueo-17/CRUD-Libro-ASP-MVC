using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaAdmi.Models;

public partial class Libro
{
    public int Id { get; set; }

    public int IdAutot { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Editoral { get; set; }

    public int Edicion { get; set; }

    public string? Clasificacion { get; set; }

    public string? AnioPublicacion { get; set; }

    //es que cunado haga la validaciojn del moedelo no tome en cuenta esto
    [ValidateNever]  
    public virtual Autore IdAutotNavigation { get; set; } = null!;
}
