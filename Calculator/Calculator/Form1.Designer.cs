namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPlusMinus = new System.Windows.Forms.Button();
            this.bt_Nula = new System.Windows.Forms.Button();
            this.bt_DesCarka = new System.Windows.Forms.Button();
            this.bt_Jedna = new System.Windows.Forms.Button();
            this.bt_Dva = new System.Windows.Forms.Button();
            this.bt_Tri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlusMinus
            // 
            this.btPlusMinus.Location = new System.Drawing.Point(12, 286);
            this.btPlusMinus.Name = "btPlusMinus";
            this.btPlusMinus.Size = new System.Drawing.Size(75, 23);
            this.btPlusMinus.TabIndex = 0;
            this.btPlusMinus.Text = "+ -";
            this.btPlusMinus.UseVisualStyleBackColor = true;
            // 
            // bt_Nula
            // 
            this.bt_Nula.Location = new System.Drawing.Point(93, 286);
            this.bt_Nula.Name = "bt_Nula";
            this.bt_Nula.Size = new System.Drawing.Size(75, 23);
            this.bt_Nula.TabIndex = 1;
            this.bt_Nula.Text = "0";
            this.bt_Nula.UseVisualStyleBackColor = true;
            // 
            // bt_DesCarka
            // 
            this.bt_DesCarka.Location = new System.Drawing.Point(174, 286);
            this.bt_DesCarka.Name = "bt_DesCarka";
            this.bt_DesCarka.Size = new System.Drawing.Size(75, 23);
            this.bt_DesCarka.TabIndex = 2;
            this.bt_DesCarka.Text = ",";
            this.bt_DesCarka.UseVisualStyleBackColor = true;
            // 
            // bt_Jedna
            // 
            this.bt_Jedna.Location = new System.Drawing.Point(12, 257);
            this.bt_Jedna.Name = "bt_Jedna";
            this.bt_Jedna.Size = new System.Drawing.Size(75, 23);
            this.bt_Jedna.TabIndex = 3;
            this.bt_Jedna.Text = "1";
            this.bt_Jedna.UseVisualStyleBackColor = true;
            // 
            // bt_Dva
            // 
            this.bt_Dva.Location = new System.Drawing.Point(93, 257);
            this.bt_Dva.Name = "bt_Dva";
            this.bt_Dva.Size = new System.Drawing.Size(75, 23);
            this.bt_Dva.TabIndex = 4;
            this.bt_Dva.Text = "2";
            this.bt_Dva.UseVisualStyleBackColor = true;
            // 
            // bt_Tri
            // 
            this.bt_Tri.Location = new System.Drawing.Point(174, 257);
            this.bt_Tri.Name = "bt_Tri";
            this.bt_Tri.Size = new System.Drawing.Size(75, 23);
            this.bt_Tri.TabIndex = 5;
            this.bt_Tri.Text = "3";
            this.bt_Tri.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Tri);
            this.Controls.Add(this.bt_Dva);
            this.Controls.Add(this.bt_Jedna);
            this.Controls.Add(this.bt_DesCarka);
            this.Controls.Add(this.bt_Nula);
            this.Controls.Add(this.btPlusMinus);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPlusMinus;
        private System.Windows.Forms.Button bt_Nula;
        private System.Windows.Forms.Button bt_DesCarka;
        private System.Windows.Forms.Button bt_Jedna;
        private System.Windows.Forms.Button bt_Dva;
        private System.Windows.Forms.Button bt_Tri;
        private System.Windows.Forms.Button button1;
    }
}

