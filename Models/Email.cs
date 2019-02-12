using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SabinoFarma.Models
{
    public class Email
    {
        [Required(ErrorMessage = "O nome deve ser informado.!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nome deve ter entre 5 e 50 caracteres!")]
        public string FromName { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string FromEmail { get; set; }

        [Required(ErrorMessage = "O telefone deve ser informado.!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (000) 000-0000")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Ínforme a descrição.")]
        [StringLength(5000, MinimumLength = 10, ErrorMessage = "Nome deve ter entre 10 e 100 caracteres!")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        public HttpPostedFileBase Upload { get; set; }

    }
}