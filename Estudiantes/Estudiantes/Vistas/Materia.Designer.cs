﻿
namespace Estudiantes.Vistas
{
    partial class Materia
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
            this.textMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Guaradar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMateria
            // 
            this.textMateria.Location = new System.Drawing.Point(211, 96);
            this.textMateria.Name = "textMateria";
            this.textMateria.Size = new System.Drawing.Size(100, 20);
            this.textMateria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NombreMateria";
            // 
            // Guaradar
            // 
            this.Guaradar.Location = new System.Drawing.Point(402, 93);
            this.Guaradar.Name = "Guaradar";
            this.Guaradar.Size = new System.Drawing.Size(75, 23);
            this.Guaradar.TabIndex = 2;
            this.Guaradar.Text = "Save";
            this.Guaradar.UseVisualStyleBackColor = true;
            this.Guaradar.Click += new System.EventHandler(this.Guaradar_Click);
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Guaradar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMateria);
            this.Name = "Materia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guaradar;
    }
}