﻿namespace API
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
            btnConsulta = new Button();
            btnLimpiar = new Button();
            pictureBox1 = new PictureBox();
            txtBusqueda = new TextBox();
            lblNombre = new Label();
            lblAltura = new Label();
            lblPeso = new Label();
            pictureBox2 = new PictureBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(299, 30);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(126, 23);
            btnConsulta.TabIndex = 0;
            btnConsulta.Text = "Buscar/Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(342, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(143, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(65, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 292);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(65, 31);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(184, 23);
            txtBusqueda.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(65, 371);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "label1";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(192, 371);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(38, 15);
            lblAltura.TabIndex = 5;
            lblAltura.Text = "label2";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(299, 371);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(38, 15);
            lblPeso.TabIndex = 6;
            lblPeso.Text = "label3";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(465, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(323, 292);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(654, 420);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBox2);
            Controls.Add(lblPeso);
            Controls.Add(lblAltura);
            Controls.Add(lblNombre);
            Controls.Add(txtBusqueda);
            Controls.Add(pictureBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnConsulta);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsulta;
        private Button btnLimpiar;
        private PictureBox pictureBox1;
        private TextBox txtBusqueda;
        private Label lblNombre;
        private Label lblAltura;
        private Label lblPeso;
        private PictureBox pictureBox2;
        private Button btnGuardar;
    }
}
