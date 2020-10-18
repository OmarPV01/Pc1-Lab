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


         [Column("name")]

        public string nombre { get; set; }

         [Column("lastname")]

        public string apellido { get; set; }

       [Column("district")]

        public string distrito { get; set; }

     [Column("bank")]

        public string banco { get; set; }


        [Column("age")]

        public int edad { get; set; }
         [Column("gender")]

        public string genero { get; set; }

        [NotMapped]

        public String Respuesta { get; set; }
    }
}