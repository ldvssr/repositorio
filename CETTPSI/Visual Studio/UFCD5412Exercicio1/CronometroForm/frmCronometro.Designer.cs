namespace CronometroForm
{
    partial class frmCronometro
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
            this.components = new System.ComponentModel.Container();
            this.ButtonOnOff = new System.Windows.Forms.Button();
            this.LabelContador = new System.Windows.Forms.Label();
            this.TimerRelogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ButtonOnOff
            // 
            this.ButtonOnOff.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonOnOff.Location = new System.Drawing.Point(13, 50);
            this.ButtonOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonOnOff.Name = "ButtonOnOff";
            this.ButtonOnOff.Size = new System.Drawing.Size(269, 44);
            this.ButtonOnOff.TabIndex = 0;
            this.ButtonOnOff.Text = "Liga";
            this.ButtonOnOff.UseVisualStyleBackColor = true;
            this.ButtonOnOff.Click += new System.EventHandler(this.ButtonOnOff_Click);
            // 
            // LabelContador
            // 
            this.LabelContador.AutoSize = true;
            this.LabelContador.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelContador.Location = new System.Drawing.Point(43, 9);
            this.LabelContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelContador.Name = "LabelContador";
            this.LabelContador.Size = new System.Drawing.Size(209, 37);
            this.LabelContador.TabIndex = 1;
            this.LabelContador.Text = "00:00:00:000";
            // 
            // TimerRelogio
            // 
            this.TimerRelogio.Interval = 1;
            this.TimerRelogio.Tick += new System.EventHandler(this.TimerRelogio_Tick);
            // 
            // frmCronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 107);
            this.Controls.Add(this.LabelContador);
            this.Controls.Add(this.ButtonOnOff);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCronometro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronómetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonOnOff;
        private Label LabelContador;
        private System.Windows.Forms.Timer TimerRelogio;
    }
}