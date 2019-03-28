namespace JogodoGalo
{
    partial class guardar
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
            this.bguardar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(79, 146);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(75, 23);
            this.bguardar.TabIndex = 0;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(279, 146);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(75, 23);
            this.bcancelar.TabIndex = 1;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Jogador: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 202);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.bguardar);
            this.Name = "guardar";
            this.Text = "guardar";
            this.Load += new System.EventHandler(this.guardar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}