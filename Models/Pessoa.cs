using System.ComponentModel.DataAnnotations;

namespace teste1.Models
{
    public class Pessoa
    {
        /* o get é um metodo que retorna o valor atual de um atrobuto 
         O set permite definir ou modificar o valor de um atributo */
        [Display (Name = "Código do Cliente")]
        public int PessoaId { get; set; }
        [Display (Name = "Nome do Clienta")]
        public string? Nome { get; set; }

        public string? Email { get; set; }
    }
}
