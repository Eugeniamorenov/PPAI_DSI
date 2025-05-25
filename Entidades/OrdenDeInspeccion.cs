using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class OrdenDeInspeccion
    {
        public DateTime fechaHoraCierre { get; set; }
        public DateTime fechaHoraFinalizacion { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public int numeroOrden { get; set; }
        public string observaciones { get; set; }

        public EstacionSismologica EstacionSismologica { get; set; }

        // para mostrar en el comboBox
        public string DescripcionCompleta =>
        $"Numero Orden {numeroOrden} - Finalización {fechaHoraFinalizacion.ToShortDateString()} - Estación {EstacionSismologica?.nombre} - Sismógrafo {EstacionSismologica?.Sismografo?.nroSerie}";


        public List<MotivoFueraServicio> MotivosCierre { get; set; } = new List<MotivoFueraServicio>();

        public void CerrarOrden(string observaciones, List<MotivoFueraServicio> motivos)
        {
            this.observaciones = observaciones;
            this.MotivosCierre = motivos;
            this.fechaHoraCierre = DateTime.Now;
        }
       
    }
}
