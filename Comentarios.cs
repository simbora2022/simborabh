using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBackEnd_Simbora.Models
{
    [Table("Comentários")]
    public class Comentarios
    {

        public int Id { get; set; }

        [Display(Name = "Nome do Evento")]
        [Required(ErrorMessage = "Obrigatório informar o nome do evento")]
        public string NomeEvento { get; set; }

       
        public int Nota { get; set; }

        [Display(Name = "Comentário")]
        public string Comentario { get; set; }

        [Display(Name = "Evento")]
        [Required(ErrorMessage = "Obrigatório informar o nome do evento!")]
        public int EventoId { get; set; }

        [ForeignKey("EventoId")]

        public Evento Evento { get; set; }
    }
}
