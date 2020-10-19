using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calculadoramvc.Models
{
    [Table("persona")]
    public class Registrar
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Column("ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Nombre")]
        [Display(Name="Nombre")]
        [Column("nombre")]
        public String Nombre{ get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Apellido")]
        [Display(Name="Apellido")]
        [Column("apellido")]
        public String Apellido{ get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Distrito")]
        [Display(Name="Distrito")]
        [Column("distrito")]
        public String Distrito{ get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Banco")]
        [Display(Name="Banco")]
        [Column("banco")]
        public String Banco{ get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Edad")]
        [Display(Name="Edad")]
        [Column("edad")]
        public int Edad{ get; set; }

        [Required(ErrorMessage = "Por favor ingrese su Genero")]
        [Display(Name="Genero")]
        [Column("genero")]
        public String Genero{ get; set; }

        [Display(Name="Author")]
        [Column("author")]
        public String Autor{ get; set; }

        [NotMapped]
        public String Respuesta { get; set; }
    }
}
