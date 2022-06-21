using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBackEnd_Simbora.Models
{
	[Table("Eventos")]
	public class Evento
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Obrigatório informar o nome!")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "Obrigatório informar a Data!")]
		public DateTime Data { get; set; }
		[Required(ErrorMessage = "Obrigatório informar o Horário!")]

		[Display(Name = "Horário")]
		public int Horario { get; set; }
		[Required(ErrorMessage = "Obrigatório informar o local!")]
		public string Local { get; set; }

		[Display(Name = "Mais Informações")]
		public string MaisInformacoes { get; set; }

       [Display(Name = "CPF")]
        public string CPF { get; set; }

        public ICollection<Comentarios> Comentario { get; set; }


	}

	
}
