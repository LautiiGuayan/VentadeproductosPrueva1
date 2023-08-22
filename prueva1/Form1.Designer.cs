namespace prueva1
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
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.CheckBox();
            this.C2 = new System.Windows.Forms.CheckBox();
            this.C3 = new System.Windows.Forms.CheckBox();
            this.L1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.TOTAL = new System.Windows.Forms.Label();
            this.TOTAL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(313, 42);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(130, 42);
            this.B1.TabIndex = 0;
            this.B1.Text = "CALCULAR";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(25, 42);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(235, 29);
            this.C1.TabIndex = 1;
            this.C1.Text = "ZAPATILLAS-$35000";
            this.C1.UseVisualStyleBackColor = true;
            this.C1.CheckedChanged += new System.EventHandler(this.C1_CheckedChanged);
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(25, 83);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(202, 29);
            this.C2.TabIndex = 2;
            this.C2.Text = "REMERAS-$2500";
            this.C2.UseVisualStyleBackColor = true;
            this.C2.CheckedChanged += new System.EventHandler(this.C2_CheckedChanged);
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(25, 124);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(188, 29);
            this.C3.TabIndex = 3;
            this.C3.Text = "GORRAS-$1200";
            this.C3.UseVisualStyleBackColor = true;
            this.C3.CheckedChanged += new System.EventHandler(this.C3_CheckedChanged);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(283, 227);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(0, 25);
            this.L1.TabIndex = 4;
            this.L1.Click += new System.EventHandler(this.L1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUCTOS SELECCIONADOS:";
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(313, 99);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(130, 42);
            this.B2.TabIndex = 6;
            this.B2.Text = "LIMPIAR";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(313, 156);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(130, 42);
            this.B3.TabIndex = 7;
            this.B3.Text = "CERRAR";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(20, 186);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(86, 25);
            this.TOTAL.TabIndex = 8;
            this.TOTAL.Text = "TOTAL:";
            // 
            // TOTAL1
            // 
            this.TOTAL1.AutoSize = true;
            this.TOTAL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL1.Location = new System.Drawing.Point(112, 186);
            this.TOTAL1.Name = "TOTAL1";
            this.TOTAL1.Size = new System.Drawing.Size(0, 25);
            this.TOTAL1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 478);
            this.Controls.Add(this.TOTAL1);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.CheckBox C1;
        private System.Windows.Forms.CheckBox C2;
        private System.Windows.Forms.CheckBox C3;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label TOTAL1;
    }
}

