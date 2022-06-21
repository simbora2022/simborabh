using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBackEnd_Simbora.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        
        [Required(ErrorMessage = "Obrigatório informar o CPF")]
        public string CPF { get; set; }

       
        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        public string Nome { get; set; }
             

        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a perfil")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Promoter,
        Cliente
    }
}
