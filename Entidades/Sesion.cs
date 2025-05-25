using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Sesion
    {
        public DateTime fechaHoraFin {  get; set; }
        public DateTime fechaHoraInicio { get; set; }

        public Usuario usuario { get; set; }
    }
}
