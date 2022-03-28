using System.ComponentModel.DataAnnotations;

namespace AgenciaViaje.Models
{
    public class Contato
    {   
        [Key()]
        public int IdContato { get; set; }

        public string Nome { get; set; }

        public int Telefone { get; set; }

        public string Email { get; set; }
    }
}
