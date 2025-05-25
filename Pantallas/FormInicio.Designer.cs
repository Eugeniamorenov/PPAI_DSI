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
            labelBienvenido = new Label();
            btnCerrarOrdInspeccion = new Button();
            SuspendLayout();
            // 
            // labelBienvenido
            // 
            labelBienvenido.AutoSize = true;
            labelBienvenido.Font = new Font("Berlin Sans FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBienvenido.Location = new Point(142, 41);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(233, 30);
            labelBienvenido.TabIndex = 0;
            labelBienvenido.Text = "Bienvenido Usuario!";
            // 
            // btnCerrarOrdInspeccion
            // 
            btnCerrarOrdInspeccion.Location = new Point(177, 121);
            btnCerrarOrdInspeccion.Name = "btnCerrarOrdInspeccion";
            btnCerrarOrdInspeccion.Size = new Size(173, 35);
            btnCerrarOrdInspeccion.TabIndex = 1;
            btnCerrarOrdInspeccion.Text = "Cerrar orden de inspección";
            btnCerrarOrdInspeccion.UseVisualStyleBackColor = true;
            btnCerrarOrdInspeccion.Click += button1_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 276);
            Controls.Add(btnCerrarOrdInspeccion);
            Controls.Add(labelBienvenido);
            Name = "FormInicio";
            Text = "Bienvenido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenido;
        private Button btnCerrarOrdInspeccion;
    }
}
