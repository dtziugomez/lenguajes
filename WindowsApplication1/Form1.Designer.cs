namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cblLenguajes = new System.Windows.Forms.CheckedListBox();
            this.lbLenguajesSeleccionados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cblLenguajes
            // 
            this.cblLenguajes.FormattingEnabled = true;
            this.cblLenguajes.Items.AddRange(new object[] {
            "Latin",
            " Greek",
            " Cylink",
            " Armenian",
            "  Hebrew",
            "   Arabic",
            " Devanagari",
            "  Bergali",
            "  Gurmulchi",
            "  Gujarati",
            "   Oriya",
            "    Tami",
            "    Telugo",
            "   Kernada",
            "   Mayalam",
            "   Thai",
            "     lao",
            "    Georgian",
            "     Tibetan",
            "     Japonese kama"});
            this.cblLenguajes.Location = new System.Drawing.Point(25, 47);
            this.cblLenguajes.Name = "cblLenguajes";
            this.cblLenguajes.Size = new System.Drawing.Size(120, 154);
            this.cblLenguajes.TabIndex = 0;
            this.cblLenguajes.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.cblLenguajes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblLenguajes_ItemCheck);
            // 
            // lbLenguajesSeleccionados
            // 
            this.lbLenguajesSeleccionados.FormattingEnabled = true;
            this.lbLenguajesSeleccionados.Location = new System.Drawing.Point(160, 70);
            this.lbLenguajesSeleccionados.Name = "lbLenguajesSeleccionados";
            this.lbLenguajesSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLenguajesSeleccionados.Size = new System.Drawing.Size(120, 95);
            this.lbLenguajesSeleccionados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "lenguajes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lenguajes seleccionados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLenguajesSeleccionados);
            this.Controls.Add(this.cblLenguajes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cblLenguajes;
        private System.Windows.Forms.ListBox lbLenguajesSeleccionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

