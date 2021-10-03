
namespace WindowsFormsApp1.Vistas
{
    partial class FmrResta
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
            this.Dato1 = new System.Windows.Forms.TextBox();
            this.Dato2 = new System.Windows.Forms.TextBox();
            this.ElResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dato1
            // 
            this.Dato1.Location = new System.Drawing.Point(85, 54);
            this.Dato1.Name = "Dato1";
            this.Dato1.Size = new System.Drawing.Size(100, 20);
            this.Dato1.TabIndex = 0;
            // 
            // Dato2
            // 
            this.Dato2.Location = new System.Drawing.Point(223, 54);
            this.Dato2.Name = "Dato2";
            this.Dato2.Size = new System.Drawing.Size(100, 20);
            this.Dato2.TabIndex = 1;
            // 
            // ElResultado
            // 
            this.ElResultado.Location = new System.Drawing.Point(370, 54);
            this.ElResultado.Name = "ElResultado";
            this.ElResultado.Size = new System.Drawing.Size(75, 23);
            this.ElResultado.TabIndex = 2;
            this.ElResultado.Text = "Resultado";
            this.ElResultado.UseVisualStyleBackColor = true;
            this.ElResultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese un valor";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese un valor";
            // 
            // FmrResta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElResultado);
            this.Controls.Add(this.Dato2);
            this.Controls.Add(this.Dato1);
            this.Name = "FmrResta";
            this.Text = "FmrResta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Dato1;
        private System.Windows.Forms.TextBox Dato2;
        private System.Windows.Forms.Button ElResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}