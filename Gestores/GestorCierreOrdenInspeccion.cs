using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI_sismo.Entidades;


namespace PPAI_DSI_sismo.Gestores
{
    public class GestorCierreOrdenInspeccion
    {
        public List<OrdenDeInspeccion> ObtenerOrdenesDisponibles()
        {
            return new List<OrdenDeInspeccion>
            {
                new OrdenDeInspeccion { numeroOrden = 1, fechaHoraFinalizacion = new DateTime(8 / 05 / 2025), EstacionSismologica = new EstacionSismologica { nombre = "Ushuaia (Tierra del Fuego)", Sismografo = new Sismografo { nroSerie = 242 } } },
                new OrdenDeInspeccion { numeroOrden = 2, fechaHoraFinalizacion = new DateTime(9 / 05 / 2025), EstacionSismologica = new EstacionSismologica { nombre = "Paso Flores (Rio Negro)", Sismografo = new Sismografo { nroSerie = 254 } } },
                new OrdenDeInspeccion { numeroOrden = 3, fechaHoraFinalizacion = new DateTime(10 / 05 / 2025), EstacionSismologica = new EstacionSismologica { nombre = "San Lorenzo (Salta)", Sismografo = new Sismografo { nroSerie = 332 } } },
                new OrdenDeInspeccion { numeroOrden = 4, fechaHoraFinalizacion = new DateTime(11 / 05 / 2025), EstacionSismologica = new EstacionSismologica { nombre = "Humahuaca (Jujuy)", Sismografo = new Sismografo { nroSerie = 410 } } }
            };
        }

        public List<MotivoTipo> obtenerMotivos()
        {
            // lista de motivos
            return new List<MotivoTipo>
            {
                new MotivoTipo { descripcion = "Falla ténica" },
                new MotivoTipo { descripcion = "Mantenimiento" },
                new MotivoTipo { descripcion = "Sin energía" },

             };
        }

        

    }
}
