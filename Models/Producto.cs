
using System.ComponentModel.DataAnnotations;

public class Cliente{
    public String Id{get;set;}

    [Display(Name ="Nombre del Producto")]
    [Required]
    public String NombreProducto{get;set;}

    [Display(Name ="Descripcion del Producto")]
    [Required]
    public String Descripcion{get;set;}

    [Display(Name ="Precio del producto")]
    [Required]
    public Double Precio{get;set;}

    public Double IGV{get;set;}
}