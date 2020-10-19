using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formulario.Models
{
       [Table("t_bono")]
     
    public class Formularios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        [Column("name")]

        public string nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [Column("lastname")]

        public string apellido { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un Distrito")]
        [Display(Name="Distrito")]
        [Column("district")]

        public string distrito { get; set; }

        [Column("bank")]

        public string banco { get; set; }

        [Required(ErrorMessage = "Por favor ingrese una Edad")]
        [Display(Name="Edad")]
        [Column("age")]

        public int edad { get; set; }
        [Column("gender")]

        public string genero { get; set; }

        [NotMapped]

        public String Respuesta { get; set; }
    }
}