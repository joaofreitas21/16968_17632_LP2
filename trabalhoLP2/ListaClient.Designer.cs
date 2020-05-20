namespace TrabalhoLP2
{
    partial class ListaClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.COdigo = new System.Windows.Forms.Label();
            this.codC = new System.Windows.Forms.TextBox();
            this.codH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(674, 329);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(93, 42);
            this.Voltar.TabIndex = 1;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submeter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo Hotel";
            // 
            // COdigo
            // 
            this.COdigo.AutoSize = true;
            this.COdigo.Location = new System.Drawing.Point(38, 40);
            this.COdigo.Name = "COdigo";
            this.COdigo.Size = new System.Drawing.Size(75, 13);
            this.COdigo.TabIndex = 5;
            this.COdigo.Text = "Codigo Cliente";
            // 
            // codC
            // 
            this.codC.Location = new System.Drawing.Point(129, 37);
            this.codC.Name = "codC";
            this.codC.Size = new System.Drawing.Size(119, 20);
            this.codC.TabIndex = 6;
            // 
            // codH
            // 
            this.codH.Location = new System.Drawing.Point(383, 37);
            this.codH.Name = "codH";
            this.codH.Size = new System.Drawing.Size(121, 20);
            this.codH.TabIndex = 7;
            // 
            // ListaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 394);
            this.Controls.Add(this.codH);
            this.Controls.Add(this.codC);
            this.Controls.Add(this.COdigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaClient";
            this.Text = "ListaClient";
            this.Load += new System.EventHandler(this.ListaClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codC;
        private System.Windows.Forms.TextBox codH;
        public System.Windows.Forms.Label COdigo;
    }
}