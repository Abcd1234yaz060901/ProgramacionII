namespace Tarea_1_modulo_2
{
    partial class Categoria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rowguidLabel;
            System.Windows.Forms.Label modifiedDateLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            System.Windows.Forms.Label productCategoryIDLabel;
            this.dB_A2ED31_itlaDataSet = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSet();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryTableAdapter = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.ProductCategoryTableAdapter();
            this.tableAdapterManager = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.TableAdapterManager();
            this.productCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidTextBox = new System.Windows.Forms.TextBox();
            this.modifiedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.productCategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.CrearBoton = new System.Windows.Forms.Button();
            this.ModificarBoton = new System.Windows.Forms.Button();
            rowguidLabel = new System.Windows.Forms.Label();
            modifiedDateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            productCategoryIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2ED31_itlaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingNavigator)).BeginInit();
            this.productCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rowguidLabel
            // 
            rowguidLabel.AutoSize = true;
            rowguidLabel.Location = new System.Drawing.Point(29, 270);
            rowguidLabel.Name = "rowguidLabel";
            rowguidLabel.Size = new System.Drawing.Size(123, 32);
            rowguidLabel.TabIndex = 2;
            rowguidLabel.Text = "rowguid:";
            // 
            // modifiedDateLabel
            // 
            modifiedDateLabel.AutoSize = true;
            modifiedDateLabel.Location = new System.Drawing.Point(29, 363);
            modifiedDateLabel.Name = "modifiedDateLabel";
            modifiedDateLabel.Size = new System.Drawing.Size(199, 32);
            modifiedDateLabel.TabIndex = 4;
            modifiedDateLabel.Text = "Modified Date:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(29, 179);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(98, 32);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // dB_A2ED31_itlaDataSet
            // 
            this.dB_A2ED31_itlaDataSet.DataSetName = "DB_A2ED31_itlaDataSet";
            this.dB_A2ED31_itlaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.dB_A2ED31_itlaDataSet;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductCategoryTableAdapter = this.productCategoryTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productCategoryBindingNavigator
            // 
            this.productCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productCategoryBindingNavigator.BindingSource = this.productCategoryBindingSource;
            this.productCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productCategoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.productCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productCategoryBindingNavigatorSaveItem});
            this.productCategoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productCategoryBindingNavigator.Name = "productCategoryBindingNavigator";
            this.productCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productCategoryBindingNavigator.Size = new System.Drawing.Size(1173, 51);
            this.productCategoryBindingNavigator.TabIndex = 0;
            this.productCategoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(94, 44);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 51);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // productCategoryBindingNavigatorSaveItem
            // 
            this.productCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productCategoryBindingNavigatorSaveItem.Image")));
            this.productCategoryBindingNavigatorSaveItem.Name = "productCategoryBindingNavigatorSaveItem";
            this.productCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 44);
            this.productCategoryBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productCategoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.ProductCategoryBindingNavigatorSaveItem_Click);
            // 
            // productCategoryDataGridView
            // 
            this.productCategoryDataGridView.AutoGenerateColumns = false;
            this.productCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productCategoryDataGridView.DataSource = this.productCategoryBindingSource;
            this.productCategoryDataGridView.Location = new System.Drawing.Point(35, 474);
            this.productCategoryDataGridView.Name = "productCategoryDataGridView";
            this.productCategoryDataGridView.RowHeadersWidth = 102;
            this.productCategoryDataGridView.RowTemplate.Height = 40;
            this.productCategoryDataGridView.Size = new System.Drawing.Size(1104, 567);
            this.productCategoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductCategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductCategoryID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "rowguid";
            this.dataGridViewTextBoxColumn3.HeaderText = "rowguid";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // rowguidTextBox
            // 
            this.rowguidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "rowguid", true));
            this.rowguidTextBox.Location = new System.Drawing.Point(321, 267);
            this.rowguidTextBox.Name = "rowguidTextBox";
            this.rowguidTextBox.Size = new System.Drawing.Size(440, 38);
            this.rowguidTextBox.TabIndex = 3;
            // 
            // modifiedDateDateTimePicker
            // 
            this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productCategoryBindingSource, "ModifiedDate", true));
            this.modifiedDateDateTimePicker.Location = new System.Drawing.Point(321, 357);
            this.modifiedDateDateTimePicker.Name = "modifiedDateDateTimePicker";
            this.modifiedDateDateTimePicker.Size = new System.Drawing.Size(440, 38);
            this.modifiedDateDateTimePicker.TabIndex = 5;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "Name", true));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(321, 176);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(440, 39);
            this.nameComboBox.TabIndex = 7;
            // 
            // productCategoryIDLabel
            // 
            productCategoryIDLabel.AutoSize = true;
            productCategoryIDLabel.Location = new System.Drawing.Point(29, 97);
            productCategoryIDLabel.Name = "productCategoryIDLabel";
            productCategoryIDLabel.Size = new System.Drawing.Size(277, 32);
            productCategoryIDLabel.TabIndex = 8;
            productCategoryIDLabel.Text = "Product Category ID:";
            // 
            // productCategoryIDTextBox
            // 
            this.productCategoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "ProductCategoryID", true));
            this.productCategoryIDTextBox.Location = new System.Drawing.Point(321, 97);
            this.productCategoryIDTextBox.Name = "productCategoryIDTextBox";
            this.productCategoryIDTextBox.Size = new System.Drawing.Size(440, 38);
            this.productCategoryIDTextBox.TabIndex = 9;
            // 
            // CrearBoton
            // 
            this.CrearBoton.BackColor = System.Drawing.Color.Chartreuse;
            this.CrearBoton.Location = new System.Drawing.Point(881, 137);
            this.CrearBoton.Name = "CrearBoton";
            this.CrearBoton.Size = new System.Drawing.Size(216, 81);
            this.CrearBoton.TabIndex = 10;
            this.CrearBoton.Text = "Crear";
            this.CrearBoton.UseVisualStyleBackColor = false;
            // 
            // ModificarBoton
            // 
            this.ModificarBoton.BackColor = System.Drawing.Color.NavajoWhite;
            this.ModificarBoton.Location = new System.Drawing.Point(881, 270);
            this.ModificarBoton.Name = "ModificarBoton";
            this.ModificarBoton.Size = new System.Drawing.Size(216, 81);
            this.ModificarBoton.TabIndex = 11;
            this.ModificarBoton.Text = "Modificar";
            this.ModificarBoton.UseVisualStyleBackColor = false;
            this.ModificarBoton.Click += new System.EventHandler(this.ModificarBoton_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 1074);
            this.Controls.Add(this.ModificarBoton);
            this.Controls.Add(this.CrearBoton);
            this.Controls.Add(productCategoryIDLabel);
            this.Controls.Add(this.productCategoryIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(modifiedDateLabel);
            this.Controls.Add(this.modifiedDateDateTimePicker);
            this.Controls.Add(rowguidLabel);
            this.Controls.Add(this.rowguidTextBox);
            this.Controls.Add(this.productCategoryDataGridView);
            this.Controls.Add(this.productCategoryBindingNavigator);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2ED31_itlaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingNavigator)).EndInit();
            this.productCategoryBindingNavigator.ResumeLayout(false);
            this.productCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_A2ED31_itlaDataSet dB_A2ED31_itlaDataSet;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private DB_A2ED31_itlaDataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private DB_A2ED31_itlaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productCategoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productCategoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox rowguidTextBox;
        private System.Windows.Forms.DateTimePicker modifiedDateDateTimePicker;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox productCategoryIDTextBox;
        private System.Windows.Forms.Button CrearBoton;
        private System.Windows.Forms.Button ModificarBoton;
    }
}