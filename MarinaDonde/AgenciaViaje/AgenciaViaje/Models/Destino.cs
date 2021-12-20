using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaViaje.Models
{
    public class Destino
    {

        [Key]
        public int IdDestino { get; set; }
        
       
   
        public string Cidade { get; set; }
       
        
        public string Hotel { get; set; }

     
        public int Dias { get; set; }
        
        
        public string Valor { get; set; }

        public virtual List<Cliente> Cliente { get; set; }
    }
}
