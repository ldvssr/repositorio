namespace Balao
{
    partial class frmBalao
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
            this.lblAltitude = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnDescer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltitude
            // 
            this.lblAltitude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAltitude.Location = new System.Drawing.Point(275, 179);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(75, 25);
            this.lblAltitude.TabIndex = 0;
            this.lblAltitude.Text = "0";
            this.lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(275, 208);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 25);
            this.btnSubir.TabIndex = 1;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // btnDescer
            // 
            this.btnDescer.Location = new System.Drawing.Point(275, 237);
            this.btnDescer.Name = "btnDescer";
            this.btnDescer.Size = new System.Drawing.Size(75, 25);
            this.btnDescer.TabIndex = 2;
            this.btnDescer.Text = "Descer";
            this.btnDescer.UseVisualStyleBackColor = true;
            // 
            // frmBalao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 437);
            this.Controls.Add(this.btnDescer);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lblAltitude);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBalao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balão";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAltitude;
        private Button btnSubir;
        private Button btnDescer;
    }
}