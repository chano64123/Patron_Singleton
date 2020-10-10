namespace Patron_Singleton
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnAbrirFrom02 = new System.Windows.Forms.Button();
            this.btnAbrirFrom03 = new System.Windows.Forms.Button();
            this.btnConSingleton = new System.Windows.Forms.Button();
            this.btnSinSingleton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(168, 88);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(101, 43);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(304, 88);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(101, 43);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnAbrirFrom02
            // 
            this.btnAbrirFrom02.Location = new System.Drawing.Point(168, 178);
            this.btnAbrirFrom02.Name = "btnAbrirFrom02";
            this.btnAbrirFrom02.Size = new System.Drawing.Size(101, 43);
            this.btnAbrirFrom02.TabIndex = 3;
            this.btnAbrirFrom02.Text = "Abrir Form02";
            this.btnAbrirFrom02.UseVisualStyleBackColor = true;
            this.btnAbrirFrom02.Click += new System.EventHandler(this.btnAbrirFrom02_Click);
            // 
            // btnAbrirFrom03
            // 
            this.btnAbrirFrom03.Location = new System.Drawing.Point(304, 178);
            this.btnAbrirFrom03.Name = "btnAbrirFrom03";
            this.btnAbrirFrom03.Size = new System.Drawing.Size(101, 43);
            this.btnAbrirFrom03.TabIndex = 4;
            this.btnAbrirFrom03.Text = "Abrir From03";
            this.btnAbrirFrom03.UseVisualStyleBackColor = true;
            this.btnAbrirFrom03.Click += new System.EventHandler(this.btnAbrirFrom03_Click);
            // 
            // btnConSingleton
            // 
            this.btnConSingleton.Location = new System.Drawing.Point(168, 276);
            this.btnConSingleton.Name = "btnConSingleton";
            this.btnConSingleton.Size = new System.Drawing.Size(101, 43);
            this.btnConSingleton.TabIndex = 5;
            this.btnConSingleton.Text = "Con Singleton";
            this.btnConSingleton.UseVisualStyleBackColor = true;
            this.btnConSingleton.Click += new System.EventHandler(this.btnConSingleton_Click);
            // 
            // btnSinSingleton
            // 
            this.btnSinSingleton.Location = new System.Drawing.Point(304, 276);
            this.btnSinSingleton.Name = "btnSinSingleton";
            this.btnSinSingleton.Size = new System.Drawing.Size(101, 43);
            this.btnSinSingleton.TabIndex = 6;
            this.btnSinSingleton.Text = "Sin Singleton";
            this.btnSinSingleton.UseVisualStyleBackColor = true;
            this.btnSinSingleton.Click += new System.EventHandler(this.btnSinSingleton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSinSingleton);
            this.Controls.Add(this.btnConSingleton);
            this.Controls.Add(this.btnAbrirFrom03);
            this.Controls.Add(this.btnAbrirFrom02);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnAbrirFrom02;
        private System.Windows.Forms.Button btnAbrirFrom03;
        private System.Windows.Forms.Button btnConSingleton;
        private System.Windows.Forms.Button btnSinSingleton;
    }
}

