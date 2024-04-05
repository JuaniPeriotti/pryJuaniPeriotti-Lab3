namespace pryJuaniPeriotti_Lab3
{
    partial class frmFirma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAceptar = new Button();
            btnBorrar = new Button();
            lblEjeX = new Label();
            lblEjeY = new Label();
            pbFirmar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFirmar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "INSERTE SU FIRMA";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 394);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(433, 394);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblEjeX
            // 
            lblEjeX.AutoSize = true;
            lblEjeX.Location = new Point(451, 9);
            lblEjeX.Name = "lblEjeX";
            lblEjeX.Size = new Size(13, 15);
            lblEjeX.TabIndex = 3;
            lblEjeX.Text = "0";
            // 
            // lblEjeY
            // 
            lblEjeY.AutoSize = true;
            lblEjeY.Location = new Point(495, 9);
            lblEjeY.Name = "lblEjeY";
            lblEjeY.Size = new Size(13, 15);
            lblEjeY.TabIndex = 4;
            lblEjeY.Text = "0";
            // 
            // pbFirmar
            // 
            pbFirmar.Location = new Point(12, 27);
            pbFirmar.Name = "pbFirmar";
            pbFirmar.Size = new Size(496, 361);
            pbFirmar.TabIndex = 5;
            pbFirmar.TabStop = false;
            pbFirmar.Paint += pbFirmar_Paint;
            pbFirmar.MouseMove += pbFirmar_MouseMove;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(520, 425);
            Controls.Add(pbFirmar);
            Controls.Add(lblEjeY);
            Controls.Add(lblEjeX);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Name = "frmFirma";
            Text = "frmFirma";
            ((System.ComponentModel.ISupportInitialize)pbFirmar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAceptar;
        private Button btnBorrar;
        private Label lblEjeX;
        private Label lblEjeY;
        private PictureBox pbFirmar;
    }
}