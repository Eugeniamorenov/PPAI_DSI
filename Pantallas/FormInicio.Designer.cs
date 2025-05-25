using PPAI_DSI_sismo.Entidades;
using PPAI_DSI_sismo.Gestores;
namespace PPAI_DSI_sismo
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrarOrdInspeccion = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCerrarOrdInspeccion
            // 
            btnCerrarOrdInspeccion.Location = new Point(177, 121);
            btnCerrarOrdInspeccion.Name = "btnCerrarOrdInspeccion";
            btnCerrarOrdInspeccion.Size = new Size(173, 35);
            btnCerrarOrdInspeccion.TabIndex = 1;
            btnCerrarOrdInspeccion.Text = "Cerrar orden de inspección";
            btnCerrarOrdInspeccion.UseVisualStyleBackColor = true;
            btnCerrarOrdInspeccion.Click += buttonCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 46);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido Usuario!";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 276);
            Controls.Add(label1);
            Controls.Add(btnCerrarOrdInspeccion);
            Name = "FormInicio";
            Text = "Bienvenido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrarOrdInspeccion;
        private Label label1;
    }
}
