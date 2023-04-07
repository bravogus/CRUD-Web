using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace sistemaweb.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public int Idcategoria { get; set; }

        [Required(ErrorMessage = "ingrese un Nombre")]
        [StringLength(50,MinimumLength =3,
            ErrorMessage ="El Nombre debe tener mas de 3 caracteres y menos de 50")]
        public string Nombre { get; set; }

        [StringLength(255, 
    ErrorMessage = "La Descripcion no debe tener mas de 255 caracteres")]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
