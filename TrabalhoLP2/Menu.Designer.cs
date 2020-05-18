namespace TrabalhoLP2
{
    partial class Menu
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
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnempregados = new System.Windows.Forms.Button();
            this.btnquartos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16.128F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(136, 181);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(101, 32);
            this.btnHotel.TabIndex = 1;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(136, 246);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(101, 32);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnempregados
            // 
            this.btnempregados.Location = new System.Drawing.Point(136, 311);
            this.btnempregados.Name = "btnempregados";
            this.btnempregados.Size = new System.Drawing.Size(101, 32);
            this.btnempregados.TabIndex = 3;
            this.btnempregados.Text = "Empregados";
            this.btnempregados.UseVisualStyleBackColor = true;
            this.btnempregados.Click += new System.EventHandler(this.btnempregados_Click);
            // 
            // btnquartos
            // 
            this.btnquartos.Location = new System.Drawing.Point(136, 376);
            this.btnquartos.Name = "btnquartos";
            this.btnquartos.Size = new System.Drawing.Size(101, 32);
            this.btnquartos.TabIndex = 4;
            this.btnquartos.Text = "Quartos";
            this.btnquartos.UseVisualStyleBackColor = true;
            this.btnquartos.Click += new System.EventHandler(this.btnquartos_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(277, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gerir:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnquartos);
            this.Controls.Add(this.btnempregados);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnempregados;
        private System.Windows.Forms.Button btnquartos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}