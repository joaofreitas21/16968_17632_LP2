namespace TrabalhoLP2
{
    partial class Gerir_Empregados
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
            this.btnadicionaremp = new System.Windows.Forms.Button();
            this.btnremoveremp = new System.Windows.Forms.Button();
            this.btninformacaoemp = new System.Windows.Forms.Button();
            this.btnregistoemp = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerir Empregados";
            // 
            // btnadicionaremp
            // 
            this.btnadicionaremp.Location = new System.Drawing.Point(28, 99);
            this.btnadicionaremp.Margin = new System.Windows.Forms.Padding(2);
            this.btnadicionaremp.Name = "btnadicionaremp";
            this.btnadicionaremp.Size = new System.Drawing.Size(64, 28);
            this.btnadicionaremp.TabIndex = 1;
            this.btnadicionaremp.Text = "Adicionar";
            this.btnadicionaremp.UseVisualStyleBackColor = true;
            this.btnadicionaremp.Click += new System.EventHandler(this.btnadicionaremp_Click);
            // 
            // btnremoveremp
            // 
            this.btnremoveremp.Location = new System.Drawing.Point(106, 99);
            this.btnremoveremp.Margin = new System.Windows.Forms.Padding(2);
            this.btnremoveremp.Name = "btnremoveremp";
            this.btnremoveremp.Size = new System.Drawing.Size(64, 28);
            this.btnremoveremp.TabIndex = 2;
            this.btnremoveremp.Text = "Remover";
            this.btnremoveremp.UseVisualStyleBackColor = true;
            this.btnremoveremp.Click += new System.EventHandler(this.btnremoveremp_Click);
            // 
            // btninformacaoemp
            // 
            this.btninformacaoemp.Location = new System.Drawing.Point(183, 99);
            this.btninformacaoemp.Margin = new System.Windows.Forms.Padding(2);
            this.btninformacaoemp.Name = "btninformacaoemp";
            this.btninformacaoemp.Size = new System.Drawing.Size(69, 28);
            this.btninformacaoemp.TabIndex = 3;
            this.btninformacaoemp.Text = "Informação";
            this.btninformacaoemp.UseVisualStyleBackColor = true;
            this.btninformacaoemp.Click += new System.EventHandler(this.btninformacaoemp_Click);
            // 
            // btnregistoemp
            // 
            this.btnregistoemp.Location = new System.Drawing.Point(266, 99);
            this.btnregistoemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnregistoemp.Name = "btnregistoemp";
            this.btnregistoemp.Size = new System.Drawing.Size(64, 28);
            this.btnregistoemp.TabIndex = 4;
            this.btnregistoemp.Text = "Lista";
            this.btnregistoemp.UseVisualStyleBackColor = true;
            this.btnregistoemp.Click += new System.EventHandler(this.btnregistoemp_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(266, 28);
            this.btnsair.Margin = new System.Windows.Forms.Padding(2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(64, 28);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Gerir_Empregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 164);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnregistoemp);
            this.Controls.Add(this.btninformacaoemp);
            this.Controls.Add(this.btnremoveremp);
            this.Controls.Add(this.btnadicionaremp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gerir_Empregados";
            this.Text = "Gerir_Empregados";
            this.Load += new System.EventHandler(this.Gerir_Empregados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadicionaremp;
        private System.Windows.Forms.Button btnremoveremp;
        private System.Windows.Forms.Button btninformacaoemp;
        private System.Windows.Forms.Button btnregistoemp;
        private System.Windows.Forms.Button btnsair;
    }
}