
namespace Processamento_de_Salários
{
    partial class frmInserirEmpregado
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
            this.pnl = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.gbInserirEmpregado = new System.Windows.Forms.GroupBox();
            this.tbNISS = new System.Windows.Forms.TextBox();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.tbDescIRS = new System.Windows.Forms.TextBox();
            this.tbOrdenado = new System.Windows.Forms.TextBox();
            this.lblNISS = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblDescIRS = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.gbInserirEmpregado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl.Controls.Add(this.btnCancelar);
            this.pnl.Controls.Add(this.btnRegistar);
            this.pnl.Location = new System.Drawing.Point(11, 231);
            this.pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(658, 65);
            this.pnl.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 15);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(112, 15);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(107, 39);
            this.btnRegistar.TabIndex = 0;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // gbInserirEmpregado
            // 
            this.gbInserirEmpregado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbInserirEmpregado.Controls.Add(this.tbNISS);
            this.gbInserirEmpregado.Controls.Add(this.tbNIF);
            this.gbInserirEmpregado.Controls.Add(this.tbDescIRS);
            this.gbInserirEmpregado.Controls.Add(this.tbOrdenado);
            this.gbInserirEmpregado.Controls.Add(this.lblNISS);
            this.gbInserirEmpregado.Controls.Add(this.lblNIF);
            this.gbInserirEmpregado.Controls.Add(this.lblDescIRS);
            this.gbInserirEmpregado.Controls.Add(this.lblOrdenado);
            this.gbInserirEmpregado.Controls.Add(this.tbNome);
            this.gbInserirEmpregado.Controls.Add(this.tbReferencia);
            this.gbInserirEmpregado.Controls.Add(this.lblReferencia);
            this.gbInserirEmpregado.Controls.Add(this.lblNome);
            this.gbInserirEmpregado.Location = new System.Drawing.Point(11, 11);
            this.gbInserirEmpregado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInserirEmpregado.Name = "gbInserirEmpregado";
            this.gbInserirEmpregado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInserirEmpregado.Size = new System.Drawing.Size(658, 216);
            this.gbInserirEmpregado.TabIndex = 1;
            this.gbInserirEmpregado.TabStop = false;
            this.gbInserirEmpregado.Text = "Inserir Empregado";
            // 
            // tbNISS
            // 
            this.tbNISS.Location = new System.Drawing.Point(112, 131);
            this.tbNISS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNISS.Name = "tbNISS";
            this.tbNISS.Size = new System.Drawing.Size(413, 23);
            this.tbNISS.TabIndex = 11;
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(112, 109);
            this.tbNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(413, 23);
            this.tbNIF.TabIndex = 10;
            // 
            // tbDescIRS
            // 
            this.tbDescIRS.Location = new System.Drawing.Point(112, 87);
            this.tbDescIRS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDescIRS.Name = "tbDescIRS";
            this.tbDescIRS.Size = new System.Drawing.Size(413, 23);
            this.tbDescIRS.TabIndex = 9;
            // 
            // tbOrdenado
            // 
            this.tbOrdenado.Location = new System.Drawing.Point(112, 64);
            this.tbOrdenado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrdenado.Name = "tbOrdenado";
            this.tbOrdenado.Size = new System.Drawing.Size(413, 23);
            this.tbOrdenado.TabIndex = 8;
            // 
            // lblNISS
            // 
            this.lblNISS.AutoSize = true;
            this.lblNISS.Location = new System.Drawing.Point(6, 136);
            this.lblNISS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNISS.Name = "lblNISS";
            this.lblNISS.Size = new System.Drawing.Size(31, 15);
            this.lblNISS.TabIndex = 7;
            this.lblNISS.Text = "NISS";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(6, 113);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(25, 15);
            this.lblNIF.TabIndex = 6;
            this.lblNIF.Text = "NIF";
            // 
            // lblDescIRS
            // 
            this.lblDescIRS.AutoSize = true;
            this.lblDescIRS.Location = new System.Drawing.Point(5, 90);
            this.lblDescIRS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescIRS.Name = "lblDescIRS";
            this.lblDescIRS.Size = new System.Drawing.Size(76, 15);
            this.lblDescIRS.TabIndex = 5;
            this.lblDescIRS.Text = "Desconto IRS";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(4, 67);
            this.lblOrdenado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(60, 15);
            this.lblOrdenado.TabIndex = 4;
            this.lblOrdenado.Text = "Ordenado";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(112, 41);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(413, 23);
            this.tbNome.TabIndex = 3;
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(112, 18);
            this.tbReferencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(413, 23);
            this.tbReferencia.TabIndex = 2;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(6, 22);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(62, 15);
            this.lblReferencia.TabIndex = 1;
            this.lblReferencia.Text = "Referência";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 44);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // frmInserirEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(680, 307);
            this.Controls.Add(this.gbInserirEmpregado);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEmpregado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Empregado";
            this.pnl.ResumeLayout(false);
            this.gbInserirEmpregado.ResumeLayout(false);
            this.gbInserirEmpregado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox gbInserirEmpregado;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox tbNISS;
        private System.Windows.Forms.TextBox tbNIF;
        private System.Windows.Forms.TextBox tbDescIRS;
        private System.Windows.Forms.TextBox tbOrdenado;
        private System.Windows.Forms.Label lblNISS;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblDescIRS;
        private System.Windows.Forms.Label lblOrdenado;
    }
}