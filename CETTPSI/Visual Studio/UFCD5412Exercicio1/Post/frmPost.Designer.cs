namespace Post
{
    partial class frmPost
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
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGosto = new System.Windows.Forms.Button();
            this.btnDesgosto = new System.Windows.Forms.Button();
            this.lvPosts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(12, 35);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(234, 26);
            this.tbTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(12, 90);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(234, 255);
            this.tbDescricao.TabIndex = 2;
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Location = new System.Drawing.Point(12, 351);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(234, 74);
            this.btnSubmeter.TabIndex = 5;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(252, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posts";
            // 
            // btnGosto
            // 
            this.btnGosto.Location = new System.Drawing.Point(252, 351);
            this.btnGosto.Name = "btnGosto";
            this.btnGosto.Size = new System.Drawing.Size(174, 74);
            this.btnGosto.TabIndex = 7;
            this.btnGosto.Text = "Gosto";
            this.btnGosto.UseVisualStyleBackColor = true;
            this.btnGosto.Click += new System.EventHandler(this.btnGosto_Click);
            // 
            // btnDesgosto
            // 
            this.btnDesgosto.Location = new System.Drawing.Point(434, 351);
            this.btnDesgosto.Name = "btnDesgosto";
            this.btnDesgosto.Size = new System.Drawing.Size(174, 74);
            this.btnDesgosto.TabIndex = 8;
            this.btnDesgosto.Text = "Desgosto";
            this.btnDesgosto.UseVisualStyleBackColor = true;
            this.btnDesgosto.Click += new System.EventHandler(this.btnDesgosto_Click);
            // 
            // lvPosts
            // 
            this.lvPosts.Location = new System.Drawing.Point(252, 35);
            this.lvPosts.Name = "lvPosts";
            this.lvPosts.Size = new System.Drawing.Size(356, 310);
            this.lvPosts.TabIndex = 9;
            this.lvPosts.UseCompatibleStateImageBehavior = false;
            // 
            // frmPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 437);
            this.Controls.Add(this.lvPosts);
            this.Controls.Add(this.btnDesgosto);
            this.Controls.Add(this.btnGosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTitulo;
        private Label label1;
        private Label label2;
        private TextBox tbDescricao;
        private Button btnSubmeter;
        private Label label3;
        private Button btnGosto;
        private Button btnDesgosto;
        private ListView lvPosts;
    }
}