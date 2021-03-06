﻿namespace ProyectoIA_DianaTorres_JoseGalvis
{
    partial class VentanaReestricciones
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
            this.btnJugar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProporcionMax = new System.Windows.Forms.TextBox();
            this.txtNumPiedras = new System.Windows.Forms.TextBox();
            this.txtCantidadParaGanar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboQuienEmpieza = new System.Windows.Forms.ComboBox();
            this.comboQuienGana = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Quién empieza la partida?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de piedras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proporción máxima de piedras que se puede quitar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad restante de piedras para ganar o perder";
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Brown;
            this.btnJugar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJugar.Location = new System.Drawing.Point(281, 479);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(188, 66);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "¡ JUGAR !";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reestricciones";
            // 
            // txtProporcionMax
            // 
            this.txtProporcionMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProporcionMax.Location = new System.Drawing.Point(734, 249);
            this.txtProporcionMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProporcionMax.Name = "txtProporcionMax";
            this.txtProporcionMax.Size = new System.Drawing.Size(57, 28);
            this.txtProporcionMax.TabIndex = 6;
            // 
            // txtNumPiedras
            // 
            this.txtNumPiedras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPiedras.Location = new System.Drawing.Point(634, 179);
            this.txtNumPiedras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumPiedras.Name = "txtNumPiedras";
            this.txtNumPiedras.Size = new System.Drawing.Size(157, 28);
            this.txtNumPiedras.TabIndex = 7;
            // 
            // txtCantidadParaGanar
            // 
            this.txtCantidadParaGanar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadParaGanar.Location = new System.Drawing.Point(644, 329);
            this.txtCantidadParaGanar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadParaGanar.Name = "txtCantidadParaGanar";
            this.txtCantidadParaGanar.Size = new System.Drawing.Size(147, 28);
            this.txtCantidadParaGanar.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "¿Gana a quien le quede la última piedra?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(687, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "1  / ";
            // 
            // comboQuienEmpieza
            // 
            this.comboQuienEmpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQuienEmpieza.FormattingEnabled = true;
            this.comboQuienEmpieza.Items.AddRange(new object[] {
            "Yo Empiezo",
            "Empieza PC"});
            this.comboQuienEmpieza.Location = new System.Drawing.Point(634, 102);
            this.comboQuienEmpieza.Margin = new System.Windows.Forms.Padding(4);
            this.comboQuienEmpieza.Name = "comboQuienEmpieza";
            this.comboQuienEmpieza.Size = new System.Drawing.Size(157, 28);
            this.comboQuienEmpieza.TabIndex = 15;
            // 
            // comboQuienGana
            // 
            this.comboQuienGana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQuienGana.FormattingEnabled = true;
            this.comboQuienGana.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboQuienGana.Location = new System.Drawing.Point(644, 396);
            this.comboQuienGana.Margin = new System.Windows.Forms.Padding(4);
            this.comboQuienGana.Name = "comboQuienGana";
            this.comboQuienGana.Size = new System.Drawing.Size(147, 28);
            this.comboQuienGana.TabIndex = 16;
            // 
            // VentanaReestricciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 590);
            this.Controls.Add(this.comboQuienGana);
            this.Controls.Add(this.comboQuienEmpieza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidadParaGanar);
            this.Controls.Add(this.txtNumPiedras);
            this.Controls.Add(this.txtProporcionMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaReestricciones";
            this.Text = "VentanaReestricciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProporcionMax;
        private System.Windows.Forms.TextBox txtNumPiedras;
        private System.Windows.Forms.TextBox txtCantidadParaGanar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboQuienEmpieza;
        private System.Windows.Forms.ComboBox comboQuienGana;
    }
}