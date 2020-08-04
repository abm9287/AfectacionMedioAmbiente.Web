using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class Fabrica
    {
        public Camiseta CrearCamiseta(string marca="cuello redondo", string modelo = "polo")
        {
            CrearCamiseta camiseta = new Camiseta(marca, modelo);
            return camiseta;
        }
    }
}
