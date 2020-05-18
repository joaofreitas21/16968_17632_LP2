namespace TrabalhoLP2
{
    partial class Gerir_Clientes
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
            this.btnadicionarclt = new System.Windows.Forms.Button();
            this.btnremoverclt = new System.Windows.Forms.Button();
            this.btninformacaoclt = new System.Windows.Forms.Button();
            this.btnregistoclt = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerir Clientes";
            // 
            // btnadicionarclt
            // 
            this.btnadicionarclt.Location = new System.Drawing.Point(49, 130);
            this.btnadicionarclt.Name = "btnadicionarclt";
            this.btnadicionarclt.Size = new System.Drawing.Size(85, 34);
            this.btnadicionarclt.TabIndex = 1;
            this.btnadicionarclt.Text = "Adicionar";
            this.btnadicionarclt.UseVisualStyleBackColor = true;
            this.btnadicionarclt.Click += new System.EventHandler(this.btnadicionarclt_Click);
            // 
            // btnremoverclt
            // 
            this.btnremoverclt.Location = new System.Drawing.Point(158, 130);
            this.btnremoverclt.Name = "btnremoverclt";
            this.btnremoverclt.Size = new System.Drawing.Size(85, 34);
            this.btnremoverclt.TabIndex = 2;
            this.btnremoverclt.Text = "Remover";
            this.btnremoverclt.UseVisualStyleBackColor = true;
            this.btnremoverclt.Click += new System.EventHandler(this.btnremoverclt_Click);
            // 
            // btninformacaoclt
            // 
            this.btninformacaoclt.Location = new System.Drawing.Point(271, 130);
            this.btninformacaoclt.Name = "btninformacaoclt";
            this.btninformacaoclt.Size = new System.Drawing.Size(85, 34);
            this.btninformacaoclt.TabIndex = 3;
            this.btninformacaoclt.Text = "Informação";
            this.btninformacaoclt.UseVisualStyleBackColor = true;
            this.btninformacaoclt.Click += new System.EventHandler(this.btninformacaoclt_Click);
            // 
            // btnregistoclt
            // 
            this.btnregistoclt.Location = new System.Drawing.Point(387, 130);
            this.btnregistoclt.Name = "btnregistoclt";
            this.btnregistoclt.Size = new System.Drawing.Size(85, 34);
            this.btnregistoclt.TabIndex = 4;
            this.btnregistoclt.Text = "Registo";
            this.btnregistoclt.UseVisualStyleBackColor = true;
            this.btnregistoclt.Click += new System.EventHandler(this.btnregistoclt_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(387, 35);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(85, 34);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Gerir_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 215);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnregistoclt);
            this.Controls.Add(this.btninformacaoclt);
            this.Controls.Add(this.btnremoverclt);
            this.Controls.Add(this.btnadicionarclt);
            this.Controls.Add(this.label1);
            this.Name = "Gerir_Clientes";
            this.Text = "Gerir_Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadicionarclt;
        private System.Windows.Forms.Button btnremoverclt;
        private System.Windows.Forms.Button btninformacaoclt;
        private System.Windows.Forms.Button btnregistoclt;
        private System.Windows.Forms.Button btnsair;
    }
}