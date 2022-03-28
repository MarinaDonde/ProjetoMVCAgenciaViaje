using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaViaje.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string Nome { get; set; }
        public string CPF { get; set;}

        public int Telefone { get; set; }

        public string Endereco { get; set; }
 
        public string Email { get; set; }

       
        [ForeignKey("Destino")]
        public int IdDestino { get; set; }

        public virtual Destino Destino { get; set; }
    }
}
