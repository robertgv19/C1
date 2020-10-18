using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace C1_1.Models
{

    [Table("afiliado")]
    public class Formulario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id {get;set;}
        
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="nombre")]
         [Column("nombre")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="apellido")]
         [Column("apellido")]
        public String apellido { get; set; }

            [Display(Name="distrito")]
             [Column("distrito")]
        public String distrito { get; set; }

            [Display(Name="banco")]
             [Column("banco")]
        public String banco { get; set; }
        
            [Display(Name="edad")]
             [Column("edad")]
        public String edad { get; set; }

        [Display(Name="genero")]
         [Column("genero")]
        public String genero { get; set; }

        [Display(Name="autor")]
         [Column("autor")]
        public String autor { get; set; }


        [NotMapped]
        public String Respuesta { get; set; }

    }
}