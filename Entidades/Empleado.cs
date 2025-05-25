using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Empleado
    {
       public string apellido {  get; set; }
       public string mail { get; set; }
       public string nombre {  get; set; }
       public int telefono {  get; set; }
       public Rol rol { get; set; }
    }
}
