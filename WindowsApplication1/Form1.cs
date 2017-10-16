using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cblLenguajes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string objeto = this.cblLenguajes.SelectedItem.ToString();
            if (e.NewValue == CheckState.Checked)
                this.lbLenguajesSeleccionados.Items.Add(objeto);
            else
                this.lbLenguajesSeleccionados.Items.Remove(objeto);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbLeguajes = new StringBuilder();
            if (this.lbLenguajesSeleccionados.SelectedItems.Count > 0)
            {
                sbLeguajes.Append("Seleccionastes:/n/n");
                foreach (string elemento in this.lbLenguajesSeleccionados.SelectedItems)
                    sbLeguajes.Append(elemento + "/n");
            }
            else
            {
                sbLeguajes.Append("No hay elemtos seleccionados en el listbox");
            }
            MessageBox.Show(sbLeguajes.ToString(),"Seleccion de elemtos",MessageBoxButtons.OK,MessageBoxIcon.Information);        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dlrSalir = new DialogResult();
                        dlrSalir = MessageBox.Show(this, "Desea Salir de la Aplicacion", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlrSalir == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
    