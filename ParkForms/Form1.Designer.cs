﻿namespace ParkForms
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblPlaca = new TextBox();
            btnEntrada = new Button();
            btnSaida = new Button();
            label2 = new Label();
            lblEntrada = new TextBox();
            lblSaida = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            lstEntrada = new ListBox();
            lstSaida = new ListBox();
            label5 = new Label();
            lblVagas = new Label();
            label6 = new Label();
            label7 = new Label();
            labelData = new Label();
            labelHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(126, 113);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 0;
            label1.Text = "DIGITE A PLACA DO VEÍCULO";
            // 
            // lblPlaca
            // 
            lblPlaca.Location = new Point(100, 138);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(212, 23);
            lblPlaca.TabIndex = 1;
            // 
            // btnEntrada
            // 
            btnEntrada.BackColor = Color.LawnGreen;
            btnEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrada.Location = new Point(102, 179);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(93, 23);
            btnEntrada.TabIndex = 2;
            btnEntrada.Text = "ENTRADA";
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSaida
            // 
            btnSaida.BackColor = Color.Red;
            btnSaida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaida.Location = new Point(217, 179);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(95, 23);
            btnSaida.TabIndex = 3;
            btnSaida.Text = "SAÍDA";
            btnSaida.UseVisualStyleBackColor = false;
            btnSaida.Click += btnSaida_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(358, 29);
            label2.Name = "label2";
            label2.Size = new Size(202, 25);
            label2.TabIndex = 4;
            label2.Text = "PARKWAY PROGRAM";
            label2.Click += label2_Click;
            // 
            // lblEntrada
            // 
            lblEntrada.Enabled = false;
            lblEntrada.Location = new Point(102, 269);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(210, 23);
            lblEntrada.TabIndex = 6;
            // 
            // lblSaida
            // 
            lblSaida.Enabled = false;
            lblSaida.Location = new Point(102, 336);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(210, 23);
            lblSaida.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(123, 247);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 8;
            label3.Text = "DIGITE A HORA DA ENTRADA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(131, 314);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 9;
            label4.Text = "DIGITE A HORA DA SAÍDA";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(134, 380);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(143, 23);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // lstEntrada
            // 
            lstEntrada.FormattingEnabled = true;
            lstEntrada.ItemHeight = 15;
            lstEntrada.Location = new Point(556, 107);
            lstEntrada.Name = "lstEntrada";
            lstEntrada.Size = new Size(288, 154);
            lstEntrada.TabIndex = 11;
            // 
            // lstSaida
            // 
            lstSaida.FormattingEnabled = true;
            lstSaida.ItemHeight = 15;
            lstSaida.Location = new Point(555, 313);
            lstSaida.Name = "lstSaida";
            lstSaida.Size = new Size(289, 154);
            lstSaida.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(627, 487);
            label5.Name = "label5";
            label5.Size = new Size(121, 17);
            label5.TabIndex = 13;
            label5.Text = "Número de Vagas:";
            label5.Click += label5_Click;
            // 
            // lblVagas
            // 
            lblVagas.AutoSize = true;
            lblVagas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVagas.ForeColor = Color.LawnGreen;
            lblVagas.Location = new Point(744, 487);
            lblVagas.Name = "lblVagas";
            lblVagas.Size = new Size(28, 17);
            lblVagas.TabIndex = 14;
            lblVagas.Text = "ND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(666, 287);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 15;
            label6.Text = "SAÍDAS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LawnGreen;
            label7.Location = new Point(651, 73);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 16;
            label7.Text = "ENTRADAS";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelData.ForeColor = Color.Orange;
            labelData.Location = new Point(12, 9);
            labelData.Name = "labelData";
            labelData.Size = new Size(77, 15);
            labelData.TabIndex = 17;
            labelData.Text = "dd/MM/yyyy";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelHora.ForeColor = Color.Orange;
            labelHora.Location = new Point(19, 28);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(63, 15);
            labelHora.TabIndex = 18;
            labelHora.Text = "HH:mm:ss";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(960, 559);
            Controls.Add(labelHora);
            Controls.Add(labelData);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblVagas);
            Controls.Add(label5);
            Controls.Add(lstSaida);
            Controls.Add(lstEntrada);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSaida);
            Controls.Add(lblEntrada);
            Controls.Add(label2);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
            Controls.Add(lblPlaca);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lblPlaca;
        private Button btnEntrada;
        private Button btnSaida;
        private Label label2;
        private TextBox lblEntrada;
        private TextBox lblSaida;
        private Label label3;
        private Label label4;
        private Button btnRegistrar;
        private ListBox lstEntrada;
        private ListBox lstSaida;
        private Label label5;
        private Label lblVagas;
        private Label label6;
        private Label label7;
        private Label labelData;
        private Label labelHora;
        private System.Windows.Forms.Timer timer1;
    }
}