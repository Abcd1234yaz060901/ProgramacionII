using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_1_modulo_2.models;

namespace Tarea_1_modulo_2
{
    public partial class Form1 : Form
    {
        Productos c = new Productos();
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
         
          

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                var x = new DB_A2ED31_itlaDataSetTableAdapters.ProductTableAdapter();

                x.Delete1(Convert.ToInt32(productIDTextBox.Text));


                MessageBox.Show("Eliminado con Exito!,Para ver los cambios actualize");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Categoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
     
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CrearBoton_Click(object sender, EventArgs e)
        {
            try
            {
                var x = new DB_A2ED31_itlaDataSetTableAdapters.ProductTableAdapter();

                x.InsertQuery(nameTextBox.Text,productNumberTextBox.Text,makeFlagCheckBox.Checked,finishedGoodsFlagCheckBox.Checked,colorTextBox.Text,Convert.ToInt16(safetyStockLevelTextBox.Text),Convert.ToInt16(reorderPointTextBox.Text),Convert.ToDecimal(standardCostTextBox.Text),Convert.ToDecimal(listPriceTextBox.Text),null,null,null,null,Convert.ToInt32(daysToManufactureTextBox.Text),null,null,null, Convert.ToInt32(SubCategoryID.SelectedValue.ToString()), null,sellStartDateDateTimePicker.Value,null,null,Guid.Parse(rowguidTextBox.Text) , modifiedDateDateTimePicker.Value);
                MessageBox.Show("Creado con Exito!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void StandarCostBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ListPriceBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StyleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ActualizarBoton_Click(object sender, EventArgs e)
        {

            try
            {

                // TODO: esta línea de código carga datos en la tabla 'dB_A2ED31_itlaDataSet.ProductC' Puede moverla o quitarla según sea necesario.
                this.productCTableAdapter.Fill(this.dB_A2ED31_itlaDataSet.ProductC);
                // TODO: esta línea de código carga datos en la tabla 'dB_A2ED31_itlaDataSet1.ProductSubcategory' Puede moverla o quitarla según sea necesario.
                this.productSubcategoryTableAdapter.Fill(this.dB_A2ED31_itlaDataSet1.ProductSubcategory);
                // TODO: esta línea de código carga datos en la tabla 'dB_A2ED31_itlaDataSet.ProductCategory' Puede moverla o quitarla según sea necesario.
                this.productCategoryTableAdapter.Fill(this.dB_A2ED31_itlaDataSet.ProductCategory);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);        }

           
        }

        private void ModificarBoton_Click(object sender, EventArgs e)
        {

            try
            {
              
                var x = new DB_A2ED31_itlaDataSetTableAdapters.ProductTableAdapter();

                x.UpdateQuery(nameTextBox.Text, productNumberTextBox.Text, makeFlagCheckBox.Checked, finishedGoodsFlagCheckBox.Checked, colorTextBox.Text, Convert.ToInt16(safetyStockLevelTextBox.Text), Convert.ToInt16(reorderPointTextBox.Text), Convert.ToDecimal(standardCostTextBox.Text), Convert.ToDecimal(listPriceTextBox.Text), null, null, null, null, Convert.ToInt32(daysToManufactureTextBox.Text), null, null, null,Convert.ToInt32(SubCategoryID.SelectedValue.ToString()), null, sellStartDateDateTimePicker.Value, null, null, Guid.Parse(rowguidTextBox.Text), modifiedDateDateTimePicker.Value,Convert.ToInt32(productIDTextBox.Text));



                MessageBox.Show("Modificado con Exito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void SubCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
         
           
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
