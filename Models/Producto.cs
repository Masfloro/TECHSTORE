
using System.ComponentModel.DataAnnotations;

public class Producto{
    
    [Display(Name ="Nombre del Producto")]
    [Required]
    public String Nombre{get;set;}

    [Display(Name ="Descripcion del Producto")]
    [Required]
    public String Descripcion{get;set;}

    [Display(Name ="Precio del producto")]
    [Required]
    public Double Precio{get;set;}

    public Double IGV{get;set;}
}