

using System.ComponentModel.DataAnnotations;

namespace FilmesCadastro.Models
{
    public class Filme
    {
        
        public int id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string nome { get; set; }
        [Required(ErrorMessage = "A nota é obrigatória")]
        public double nota { get; set; }
        [Required(ErrorMessage = "Uma breve descrição é obrigatória")]
        public string descricao { get; set; }
    }
}
