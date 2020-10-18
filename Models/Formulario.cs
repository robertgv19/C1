using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace C1_1.Models
{

    [Table("afiliado")]
    public class Formulario
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get;set;}
        
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre_Est")]
         [Column("nombre")]
        public String Nombre_Est { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido_Est")]
         [Column("apellido")]
        public String Apellido_Est { get; set; }

            [Display(Name="Distrito")]
             [Column("distrito")]
        public String Distrito { get; set; }

            [Display(Name="Banco")]
             [Column("banco")]
        public String Banco { get; set; }
        
            [Display(Name="Edad")]
             [Column("edad")]
        public String Edad { get; set; }

        [Display(Name="Genero")]
         [Column("genero")]
        public String Genero { get; set; }

        [Display(Name="Autor")]
         [Column("autor")]
        public String Autor { get; set; }


        [NotMapped]
        public String Respuesta { get; set; }

    }
}