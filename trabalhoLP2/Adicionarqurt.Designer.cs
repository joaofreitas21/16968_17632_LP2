﻿namespace TrabalhoLP2
{
    partial class Adicionarqurt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inicioR = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.fimR = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.numC = new System.Windows.Forms.TextBox();
            this.codH = new System.Windows.Forms.TextBox();
            this.numQ = new System.Windows.Forms.TextBox();
            this.extra = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº Hotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nº Quarto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data de reserva";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Serviço extra";
            // 
            // inicioR
            // 
            this.inicioR.Location = new System.Drawing.Point(102, 208);
            this.inicioR.Margin = new System.Windows.Forms.Padding(2);
            this.inicioR.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.inicioR.Name = "inicioR";
            this.inicioR.Size = new System.Drawing.Size(144, 20);
            this.inicioR.TabIndex = 8;
            this.inicioR.Value = new System.DateTime(2020, 1, 1, 0, 1, 0, 0);
            this.inicioR.ValueChanged += new System.EventHandler(this.inicioR_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "ate";
            // 
            // fimR
            // 
            this.fimR.Location = new System.Drawing.Point(296, 208);
            this.fimR.Margin = new System.Windows.Forms.Padding(2);
            this.fimR.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fimR.Name = "fimR";
            this.fimR.Size = new System.Drawing.Size(139, 20);
            this.fimR.TabIndex = 10;
            this.fimR.Value = new System.DateTime(2020, 1, 2, 0, 0, 0, 0);
            this.fimR.ValueChanged += new System.EventHandler(this.fimR_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(94, 82);
            this.numC.Margin = new System.Windows.Forms.Padding(2);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(207, 20);
            this.numC.TabIndex = 12;
            // 
            // codH
            // 
            this.codH.Location = new System.Drawing.Point(80, 122);
            this.codH.Margin = new System.Windows.Forms.Padding(2);
            this.codH.Name = "codH";
            this.codH.Size = new System.Drawing.Size(221, 20);
            this.codH.TabIndex = 13;
            // 
            // numQ
            // 
            this.numQ.Location = new System.Drawing.Point(76, 154);
            this.numQ.Margin = new System.Windows.Forms.Padding(2);
            this.numQ.Name = "numQ";
            this.numQ.Size = new System.Drawing.Size(226, 20);
            this.numQ.TabIndex = 14;
            // 
            // extra
            // 
            this.extra.FormattingEnabled = true;
            this.extra.Items.AddRange(new object[] {
            "Limpeza Diária",
            "Bar"});
            this.extra.Location = new System.Drawing.Point(111, 249);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(118, 21);
            this.extra.TabIndex = 18;
            this.extra.Text = "Selecione Extra";
            this.extra.SelectedIndexChanged += new System.EventHandler(this.extra_SelectedIndexChanged);
            // 
            // Adicionarqurt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 335);
            this.Controls.Add(this.extra);
            this.Controls.Add(this.numQ);
            this.Controls.Add(this.codH);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fimR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inicioR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Adicionarqurt";
            this.Text = "Adicionarqurt";
            this.Load += new System.EventHandler(this.Adicionarqurt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker inicioR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fimR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numC;
        private System.Windows.Forms.TextBox codH;
        private System.Windows.Forms.TextBox numQ;
        private System.Windows.Forms.ComboBox extra;
    }
}