﻿namespace TrabalhoLP2
{
    partial class Gerir_Quartos
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
            this.btnadicionarqrt = new System.Windows.Forms.Button();
            this.btnremoverqrt = new System.Windows.Forms.Button();
            this.btninformacaoqrt = new System.Windows.Forms.Button();
            this.btncheclimqrt = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnpagamentoqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerir Quartos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnadicionarqrt
            // 
            this.btnadicionarqrt.Location = new System.Drawing.Point(24, 108);
            this.btnadicionarqrt.Name = "btnadicionarqrt";
            this.btnadicionarqrt.Size = new System.Drawing.Size(85, 34);
            this.btnadicionarqrt.TabIndex = 1;
            this.btnadicionarqrt.Text = "Adicionar";
            this.btnadicionarqrt.UseVisualStyleBackColor = true;
            this.btnadicionarqrt.Click += new System.EventHandler(this.btnadicionarqrt_Click);
            // 
            // btnremoverqrt
            // 
            this.btnremoverqrt.Location = new System.Drawing.Point(139, 108);
            this.btnremoverqrt.Name = "btnremoverqrt";
            this.btnremoverqrt.Size = new System.Drawing.Size(85, 34);
            this.btnremoverqrt.TabIndex = 2;
            this.btnremoverqrt.Text = "Remover";
            this.btnremoverqrt.UseVisualStyleBackColor = true;
            this.btnremoverqrt.Click += new System.EventHandler(this.btnremoverqrt_Click);
            // 
            // btninformacaoqrt
            // 
            this.btninformacaoqrt.Location = new System.Drawing.Point(254, 108);
            this.btninformacaoqrt.Name = "btninformacaoqrt";
            this.btninformacaoqrt.Size = new System.Drawing.Size(85, 34);
            this.btninformacaoqrt.TabIndex = 3;
            this.btninformacaoqrt.Text = "Informação";
            this.btninformacaoqrt.UseVisualStyleBackColor = true;
            this.btninformacaoqrt.Click += new System.EventHandler(this.btninformacaoqrt_Click);
            // 
            // btncheclimqrt
            // 
            this.btncheclimqrt.Location = new System.Drawing.Point(369, 108);
            this.btncheclimqrt.Name = "btncheclimqrt";
            this.btncheclimqrt.Size = new System.Drawing.Size(85, 34);
            this.btncheclimqrt.TabIndex = 4;
            this.btncheclimqrt.Text = "Check-in";
            this.btncheclimqrt.UseVisualStyleBackColor = true;
            this.btncheclimqrt.Click += new System.EventHandler(this.btncheclimqrt_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(495, 29);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(85, 32);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnpagamentoqrt
            // 
            this.btnpagamentoqrt.Location = new System.Drawing.Point(487, 108);
            this.btnpagamentoqrt.Name = "btnpagamentoqrt";
            this.btnpagamentoqrt.Size = new System.Drawing.Size(93, 34);
            this.btnpagamentoqrt.TabIndex = 7;
            this.btnpagamentoqrt.Text = "Pagamento";
            this.btnpagamentoqrt.UseVisualStyleBackColor = true;
            this.btnpagamentoqrt.Click += new System.EventHandler(this.btnpagamentoqrt_Click);
            // 
            // Gerir_Quartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 178);
            this.Controls.Add(this.btnpagamentoqrt);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncheclimqrt);
            this.Controls.Add(this.btninformacaoqrt);
            this.Controls.Add(this.btnremoverqrt);
            this.Controls.Add(this.btnadicionarqrt);
            this.Controls.Add(this.label1);
            this.Name = "Gerir_Quartos";
            this.Text = "Gerir_Quartos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadicionarqrt;
        private System.Windows.Forms.Button btnremoverqrt;
        private System.Windows.Forms.Button btninformacaoqrt;
        private System.Windows.Forms.Button btncheclimqrt;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnpagamentoqrt;
    }
}