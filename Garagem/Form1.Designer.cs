using System;

namespace Garagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_placa = new System.Windows.Forms.TextBox();
            this.button_entrada = new System.Windows.Forms.Button();
            this.button_saida = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_entrada = new System.Windows.Forms.ListBox();
            this.lb_saida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(590, 60);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "HORA";
            // 
            // textBox_placa
            // 
            this.textBox_placa.Location = new System.Drawing.Point(125, 30);
            this.textBox_placa.Name = "textBox_placa";
            this.textBox_placa.Size = new System.Drawing.Size(202, 20);
            this.textBox_placa.TabIndex = 6;
            // 
            // button_entrada
            // 
            this.button_entrada.Location = new System.Drawing.Point(39, 380);
            this.button_entrada.Name = "button_entrada";
            this.button_entrada.Size = new System.Drawing.Size(126, 43);
            this.button_entrada.TabIndex = 7;
            this.button_entrada.Text = "Entrada";
            this.button_entrada.UseVisualStyleBackColor = true;
            this.button_entrada.Click += new System.EventHandler(this.button_entrada_Click);
            // 
            // button_saida
            // 
            this.button_saida.Location = new System.Drawing.Point(194, 380);
            this.button_saida.Name = "button_saida";
            this.button_saida.Size = new System.Drawing.Size(133, 42);
            this.button_saida.TabIndex = 8;
            this.button_saida.Text = "Saida";
            this.button_saida.UseVisualStyleBackColor = true;
            this.button_saida.Click += new System.EventHandler(this.button_saida_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(354, 380);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(139, 42);
            this.button_limpar.TabIndex = 9;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lista Saida ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_entrada
            // 
            this.lb_entrada.FormattingEnabled = true;
            this.lb_entrada.Location = new System.Drawing.Point(39, 125);
            this.lb_entrada.Name = "lb_entrada";
            this.lb_entrada.Size = new System.Drawing.Size(200, 121);
            this.lb_entrada.TabIndex = 16;
            this.lb_entrada.SelectedIndexChanged += new System.EventHandler(this.lb_entrada_SelectedIndexChanged);
            // 
            // lb_saida
            // 
            this.lb_saida.FormattingEnabled = true;
            this.lb_saida.Location = new System.Drawing.Point(285, 125);
            this.lb_saida.Name = "lb_saida";
            this.lb_saida.Size = new System.Drawing.Size(214, 121);
            this.lb_saida.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_saida);
            this.Controls.Add(this.lb_entrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_saida);
            this.Controls.Add(this.button_entrada);
            this.Controls.Add(this.textBox_placa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_placa;
        private System.Windows.Forms.Button button_entrada;
        private System.Windows.Forms.Button button_saida;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_entrada;
        private System.Windows.Forms.ListBox lb_saida;

        public EventHandler Form1_Load { get; private set; }
    }
}

