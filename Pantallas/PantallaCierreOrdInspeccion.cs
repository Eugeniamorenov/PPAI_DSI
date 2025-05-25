using PPAI_DSI_sismo.Gestores;
using PPAI_DSI_sismo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_sismo.Pantallas
{
    public partial class PantallaCierreOrdInspeccion : Form
    {
        public PantallaCierreOrdInspeccion()
        {
            InitializeComponent();
        }

        private DataTable dtMotivos;

        private void PantallaCierreOrdInspeccion_Load(object sender, EventArgs e)
        {
            var gestor = new GestorCierreOrdenInspeccion();


            cmbOrdenes.DisplayMember = "DescripcionCompleta";
            cmbOrdenes.ValueMember = "numeroOrden";
            cmbOrdenes.DataSource = gestor.ObtenerOrdenesDisponibles();



            // Asignar la lista al ComboBox
            cmbMotivos.DisplayMember = "Descripcion";
            cmbMotivos.DataSource = gestor.obtenerMotivos();


            // tabla donde se guardan los motivos
            dtMotivos = new DataTable();
            dtMotivos.Columns.Add("Motivo", typeof(string));
            dtMotivos.Columns.Add("Comentario", typeof(string));

            dgvMotivos.DataSource = dtMotivos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMotivos.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un motivo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComentarioCierre.Text))
            {
                MessageBox.Show("Por favor ingrese un comentario.");
                return;
            }

            // Obtener el motivo seleccionado
            var motivoSeleccionado = (MotivoTipo)cmbMotivos.SelectedItem;

            // Agregar fila al DataTable
            dtMotivos.Rows.Add(motivoSeleccionado.descripcion, txtComentarioCierre.Text.Trim());

            // Limpiar controles para siguiente ingreso
            cmbMotivos.SelectedIndex = -1;
            txtComentarioCierre.Clear();
            cmbMotivos.Focus();
        }

        private void buttonCerrarOrden_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("Está seguro de que desea cerrar esta orden?", "Confirmacion", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (cmbOrdenes.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una orden a cerrar");
                    return;
                }


                var ordenSeleccionada = (OrdenDeInspeccion)cmbOrdenes.SelectedItem;

                List<MotivoFueraServicio> listaMotivos = new List<MotivoFueraServicio>();

                foreach (DataRow row in dtMotivos.Rows)
                {
                    var motivo = new MotivoFueraServicio
                    {
                        TipoMotivo = new MotivoTipo { descripcion = row["Motivo"].ToString() },
                        comentario = row["Comentario"].ToString()
                    };

                    listaMotivos.Add(motivo);
                }

                if (listaMotivos.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un motivo");
                    return;
                }

                ordenSeleccionada.CerrarOrden(txtObservacion.Text.Trim(), listaMotivos);



                MessageBox.Show("Orden cerrada!");


                this.Close();
            }
        }
           
    }
}
