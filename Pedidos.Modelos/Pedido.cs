using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Modelos
{
    public class Pedido
    {
        [Key] public int Id { get; set; }
       

        public string producto { get; set;}

        public int cantidad  { get; set;}

        public string? fecha { get; set;}

        //RELACION

        public int ClienteCodigoCliente { get; set;}
        public Clientes? Clientes   { get; set;}

    }
}
