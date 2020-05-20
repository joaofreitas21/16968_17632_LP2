namespace TrabalhoLP2
{
    partial class Gerir_Hotel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btninformacao = new System.Windows.Forms.Button();
            this.btnquartos = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerir Hotel";
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(8, 89);
            this.btnadicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(94, 28);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "Adicionar ";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(106, 89);
            this.btnremover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(94, 28);
            this.btnremover.TabIndex = 2;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btninformacao
            // 
            this.btninformacao.Location = new System.Drawing.Point(204, 89);
            this.btninformacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btninformacao.Name = "btninformacao";
            this.btninformacao.Size = new System.Drawing.Size(94, 28);
            this.btninformacao.TabIndex = 3;
            this.btninformacao.Text = "Informação";
            this.btninformacao.UseVisualStyleBackColor = true;
            this.btninformacao.Click += new System.EventHandler(this.btninformacao_Click);
            // 
            // btnquartos
            // 
            this.btnquartos.Location = new System.Drawing.Point(302, 89);
            this.btnquartos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnquartos.Name = "btnquartos";
            this.btnquartos.Size = new System.Drawing.Size(94, 28);
            this.btnquartos.TabIndex = 4;
            this.btnquartos.Text = "Nº Quartos Livres";
            this.btnquartos.UseVisualStyleBackColor = true;
            this.btnquartos.Click += new System.EventHandler(this.btnquartos_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(376, 10);
            this.btnsair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(64, 26);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(376, 173);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 26);
            this.button6.TabIndex = 6;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 173);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 26);
            this.button5.TabIndex = 5;
            this.button5.Text = "Load";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Gerir_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 209);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnquartos);
            this.Controls.Add(this.btninformacao);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Gerir_Hotel";
            this.Text = "Gerir_Hotel";
            this.Load += new System.EventHandler(this.Gerir_Hotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btninformacao;
        private System.Windows.Forms.Button btnquartos;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}