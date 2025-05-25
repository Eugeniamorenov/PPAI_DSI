using PPAI_DSI_sismo.Pantallas;

namespace PPAI_DSI_sismo
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            habilitarPantalla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaCierreOrdInspeccion nuevoForm = new PantallaCierreOrdInspeccion();
            nuevoForm.ShowDialog();   
        }

        public void habilitarPantalla()
        {
            //habilitar
        }
    }
}
