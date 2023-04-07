using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace sistemaweb.Models
{
    public partial class Producto
    {
        public int Idproducto { get; set; }

        [Required(ErrorMessage ="Selecione una categoria")]
        public int Idcategoria { get; set; }

        [StringLength(64, 
    ErrorMessage = "El Codigo no  debe tener mas de 64 caracteres")]
        public string Codigo { get; set; }

        [StringLength(100, MinimumLength = 3,
    ErrorMessage = "El Nombre debe tener mas de 3 caracteres y menos de 100 ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese un Precio de Venta")]
        public decimal PrecioVenta { get; set; }

        [Required(ErrorMessage = "ingrese un Stock")]
        public int Stock { get; set; }

        [StringLength(255,
          ErrorMessage = "La Descripcion no debe tener mas de 255 caracteres")]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual Categoria IdcategoriaNavigation { get; set; }
    }
}
