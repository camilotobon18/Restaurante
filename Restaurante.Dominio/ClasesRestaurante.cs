using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Restaurante.Dominio
{
    
    public class Producto
    {
        
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Foto { get; set; }
    }

    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }
    }

    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public Boolean Estado { get; set; } 
    }
}
