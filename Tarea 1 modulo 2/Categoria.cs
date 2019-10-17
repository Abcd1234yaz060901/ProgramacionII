using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1_modulo_2
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void ProductCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_A2ED31_itlaDataSet);

        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_A2ED31_itlaDataSet.ProductCategory' Puede moverla o quitarla según sea necesario.
            this.productCategoryTableAdapter.Fill(this.dB_A2ED31_itlaDataSet.ProductCategory);

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void ModificarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productCategoryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_A2ED31_itlaDataSet);

                MessageBox.Show("Modificado con Exito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
