
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
            this.pnl.Location = new System.Drawing.Point(12, 424);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(754, 108);
            this.pnl.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(452, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(160, 40);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(112, 34);
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
            this.gbInserirEmpregado.Location = new System.Drawing.Point(12, 12);
            this.gbInserirEmpregado.Name = "gbInserirEmpregado";
            this.gbInserirEmpregado.Size = new System.Drawing.Size(754, 406);
            this.gbInserirEmpregado.TabIndex = 1;
            this.gbInserirEmpregado.TabStop = false;
            this.gbInserirEmpregado.Text = "Inserir Empregado";
            // 
            // tbNISS
            // 
            this.tbNISS.Location = new System.Drawing.Point(160, 219);
            this.tbNISS.Name = "tbNISS";
            this.tbNISS.Size = new System.Drawing.Size(588, 31);
            this.tbNISS.TabIndex = 11;
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(160, 182);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(588, 31);
            this.tbNIF.TabIndex = 10;
            // 
            // tbDescIRS
            // 
            this.tbDescIRS.Location = new System.Drawing.Point(160, 145);
            this.tbDescIRS.Name = "tbDescIRS";
            this.tbDescIRS.Size = new System.Drawing.Size(588, 31);
            this.tbDescIRS.TabIndex = 9;
            // 
            // tbOrdenado
            // 
            this.tbOrdenado.Location = new System.Drawing.Point(160, 106);
            this.tbOrdenado.Name = "tbOrdenado";
            this.tbOrdenado.Size = new System.Drawing.Size(588, 31);
            this.tbOrdenado.TabIndex = 8;
            // 
            // lblNISS
            // 
            this.lblNISS.AutoSize = true;
            this.lblNISS.Location = new System.Drawing.Point(9, 226);
            this.lblNISS.Name = "lblNISS";
            this.lblNISS.Size = new System.Drawing.Size(50, 25);
            this.lblNISS.TabIndex = 7;
            this.lblNISS.Text = "NISS";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(9, 188);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(39, 25);
            this.lblNIF.TabIndex = 6;
            this.lblNIF.Text = "NIF";
            // 
            // lblDescIRS
            // 
            this.lblDescIRS.AutoSize = true;
            this.lblDescIRS.Location = new System.Drawing.Point(7, 150);
            this.lblDescIRS.Name = "lblDescIRS";
            this.lblDescIRS.Size = new System.Drawing.Size(119, 25);
            this.lblDescIRS.TabIndex = 5;
            this.lblDescIRS.Text = "Desconto IRS";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(6, 112);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(93, 25);
            this.lblOrdenado.TabIndex = 4;
            this.lblOrdenado.Text = "Ordenado";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(160, 68);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(588, 31);
            this.tbNome.TabIndex = 3;
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(160, 30);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(588, 31);
            this.tbReferencia.TabIndex = 2;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(9, 36);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(92, 25);
            this.lblReferencia.TabIndex = 1;
            this.lblReferencia.Text = "Referência";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // frmInserirEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(774, 540);
            this.Controls.Add(this.gbInserirEmpregado);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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