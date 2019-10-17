namespace Tarea_1_modulo_2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label productNumberLabel;
            System.Windows.Forms.Label makeFlagLabel;
            System.Windows.Forms.Label finishedGoodsFlagLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label listPriceLabel;
            System.Windows.Forms.Label standardCostLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label modifiedDateLabel;
            System.Windows.Forms.Label rowguidLabel;
            System.Windows.Forms.Label sellStartDateLabel;
            System.Windows.Forms.Label daysToManufactureLabel;
            System.Windows.Forms.Label reorderPointLabel;
            System.Windows.Forms.Label safetyStockLevelLabel;
            System.Windows.Forms.Label productSubcategoryIDLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubCategoryID = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A2ED31_itlaDataSet = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSet();
            this.productCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSubcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A2ED31_itlaDataSet1 = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSet();
            this.productCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyStockLevelTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reorderPointTextBox = new System.Windows.Forms.TextBox();
            this.daysToManufactureTextBox = new System.Windows.Forms.TextBox();
            this.sellStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rowguidTextBox = new System.Windows.Forms.TextBox();
            this.modifiedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.standardCostTextBox = new System.Windows.Forms.TextBox();
            this.listPriceTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.finishedGoodsFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.makeFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.productNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CrearBoton = new System.Windows.Forms.Button();
            this.ModificarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.ActualizarBoton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.productTableAdapter = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.TableAdapterManager();
            this.productCategoryTableAdapter = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.ProductCategoryTableAdapter();
            this.productCTableAdapter = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.ProductCTableAdapter();
            this.productSubcategoryTableAdapter = new Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.ProductSubcategoryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            productNumberLabel = new System.Windows.Forms.Label();
            makeFlagLabel = new System.Windows.Forms.Label();
            finishedGoodsFlagLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            listPriceLabel = new System.Windows.Forms.Label();
            standardCostLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            modifiedDateLabel = new System.Windows.Forms.Label();
            rowguidLabel = new System.Windows.Forms.Label();
            sellStartDateLabel = new System.Windows.Forms.Label();
            daysToManufactureLabel = new System.Windows.Forms.Label();
            reorderPointLabel = new System.Windows.Forms.Label();
            safetyStockLevelLabel = new System.Windows.Forms.Label();
            productSubcategoryIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2ED31_itlaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2ED31_itlaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(75, 144);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(98, 32);
            nameLabel.TabIndex = 54;
            nameLabel.Text = "Name:";
            // 
            // productNumberLabel
            // 
            productNumberLabel.AutoSize = true;
            productNumberLabel.Location = new System.Drawing.Point(1115, 47);
            productNumberLabel.Name = "productNumberLabel";
            productNumberLabel.Size = new System.Drawing.Size(228, 32);
            productNumberLabel.TabIndex = 55;
            productNumberLabel.Text = "Product Number:";
            // 
            // makeFlagLabel
            // 
            makeFlagLabel.AutoSize = true;
            makeFlagLabel.Location = new System.Drawing.Point(75, 500);
            makeFlagLabel.Name = "makeFlagLabel";
            makeFlagLabel.Size = new System.Drawing.Size(155, 32);
            makeFlagLabel.TabIndex = 56;
            makeFlagLabel.Text = "Make Flag:";
            // 
            // finishedGoodsFlagLabel
            // 
            finishedGoodsFlagLabel.AutoSize = true;
            finishedGoodsFlagLabel.Location = new System.Drawing.Point(470, 505);
            finishedGoodsFlagLabel.Name = "finishedGoodsFlagLabel";
            finishedGoodsFlagLabel.Size = new System.Drawing.Size(286, 32);
            finishedGoodsFlagLabel.TabIndex = 57;
            finishedGoodsFlagLabel.Text = "Finished Goods Flag:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(75, 351);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(91, 32);
            colorLabel.TabIndex = 58;
            colorLabel.Text = "Color:";
            // 
            // listPriceLabel
            // 
            listPriceLabel.AutoSize = true;
            listPriceLabel.Location = new System.Drawing.Point(75, 246);
            listPriceLabel.Name = "listPriceLabel";
            listPriceLabel.Size = new System.Drawing.Size(140, 32);
            listPriceLabel.TabIndex = 59;
            listPriceLabel.Text = "List Price:";
            // 
            // standardCostLabel
            // 
            standardCostLabel.AutoSize = true;
            standardCostLabel.Location = new System.Drawing.Point(534, 252);
            standardCostLabel.Name = "standardCostLabel";
            standardCostLabel.Size = new System.Drawing.Size(204, 32);
            standardCostLabel.TabIndex = 60;
            standardCostLabel.Text = "Standard Cost:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(75, 44);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(155, 32);
            productIDLabel.TabIndex = 62;
            productIDLabel.Text = "Product ID:";
            // 
            // modifiedDateLabel
            // 
            modifiedDateLabel.AutoSize = true;
            modifiedDateLabel.Location = new System.Drawing.Point(1115, 539);
            modifiedDateLabel.Name = "modifiedDateLabel";
            modifiedDateLabel.Size = new System.Drawing.Size(199, 32);
            modifiedDateLabel.TabIndex = 63;
            modifiedDateLabel.Text = "Modified Date:";
            // 
            // rowguidLabel
            // 
            rowguidLabel.AutoSize = true;
            rowguidLabel.Location = new System.Drawing.Point(1115, 357);
            rowguidLabel.Name = "rowguidLabel";
            rowguidLabel.Size = new System.Drawing.Size(123, 32);
            rowguidLabel.TabIndex = 64;
            rowguidLabel.Text = "rowguid:";
            // 
            // sellStartDateLabel
            // 
            sellStartDateLabel.AutoSize = true;
            sellStartDateLabel.Location = new System.Drawing.Point(1115, 453);
            sellStartDateLabel.Name = "sellStartDateLabel";
            sellStartDateLabel.Size = new System.Drawing.Size(206, 32);
            sellStartDateLabel.TabIndex = 65;
            sellStartDateLabel.Text = "Sell Start Date:";
            // 
            // daysToManufactureLabel
            // 
            daysToManufactureLabel.AutoSize = true;
            daysToManufactureLabel.Location = new System.Drawing.Point(75, 571);
            daysToManufactureLabel.Name = "daysToManufactureLabel";
            daysToManufactureLabel.Size = new System.Drawing.Size(292, 32);
            daysToManufactureLabel.TabIndex = 66;
            daysToManufactureLabel.Text = "Days To Manufacture:";
            // 
            // reorderPointLabel
            // 
            reorderPointLabel.AutoSize = true;
            reorderPointLabel.Location = new System.Drawing.Point(1115, 252);
            reorderPointLabel.Name = "reorderPointLabel";
            reorderPointLabel.Size = new System.Drawing.Size(198, 32);
            reorderPointLabel.TabIndex = 67;
            reorderPointLabel.Text = "Reorder Point:";
            // 
            // safetyStockLevelLabel
            // 
            safetyStockLevelLabel.AutoSize = true;
            safetyStockLevelLabel.Location = new System.Drawing.Point(1115, 148);
            safetyStockLevelLabel.Name = "safetyStockLevelLabel";
            safetyStockLevelLabel.Size = new System.Drawing.Size(258, 32);
            safetyStockLevelLabel.TabIndex = 68;
            safetyStockLevelLabel.Text = "Safety Stock Level:";
            // 
            // productSubcategoryIDLabel
            // 
            productSubcategoryIDLabel.AutoSize = true;
            productSubcategoryIDLabel.Location = new System.Drawing.Point(75, 444);
            productSubcategoryIDLabel.Name = "productSubcategoryIDLabel";
            productSubcategoryIDLabel.Size = new System.Drawing.Size(322, 32);
            productSubcategoryIDLabel.TabIndex = 69;
            productSubcategoryIDLabel.Text = "Product Subcategory ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SubCategoryID);
            this.panel1.Controls.Add(productSubcategoryIDLabel);
            this.panel1.Controls.Add(this.productCDataGridView);
            this.panel1.Controls.Add(safetyStockLevelLabel);
            this.panel1.Controls.Add(this.safetyStockLevelTextBox);
            this.panel1.Controls.Add(reorderPointLabel);
            this.panel1.Controls.Add(this.reorderPointTextBox);
            this.panel1.Controls.Add(daysToManufactureLabel);
            this.panel1.Controls.Add(this.daysToManufactureTextBox);
            this.panel1.Controls.Add(sellStartDateLabel);
            this.panel1.Controls.Add(this.sellStartDateDateTimePicker);
            this.panel1.Controls.Add(rowguidLabel);
            this.panel1.Controls.Add(this.rowguidTextBox);
            this.panel1.Controls.Add(modifiedDateLabel);
            this.panel1.Controls.Add(this.modifiedDateDateTimePicker);
            this.panel1.Controls.Add(productIDLabel);
            this.panel1.Controls.Add(this.productIDTextBox);
            this.panel1.Controls.Add(this.nameComboBox);
            this.panel1.Controls.Add(standardCostLabel);
            this.panel1.Controls.Add(this.standardCostTextBox);
            this.panel1.Controls.Add(listPriceLabel);
            this.panel1.Controls.Add(this.listPriceTextBox);
            this.panel1.Controls.Add(colorLabel);
            this.panel1.Controls.Add(this.colorTextBox);
            this.panel1.Controls.Add(finishedGoodsFlagLabel);
            this.panel1.Controls.Add(this.finishedGoodsFlagCheckBox);
            this.panel1.Controls.Add(makeFlagLabel);
            this.panel1.Controls.Add(this.makeFlagCheckBox);
            this.panel1.Controls.Add(productNumberLabel);
            this.panel1.Controls.Add(this.productNumberTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(93, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2248, 1277);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // SubCategoryID
            // 
            this.SubCategoryID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "Name", true));
            this.SubCategoryID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productCBindingSource, "ProductSubcategoryID", true));
            this.SubCategoryID.DataSource = this.productSubcategoryBindingSource;
            this.SubCategoryID.DisplayMember = "Name";
            this.SubCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCategoryID.FormattingEnabled = true;
            this.SubCategoryID.Location = new System.Drawing.Point(417, 441);
            this.SubCategoryID.Name = "SubCategoryID";
            this.SubCategoryID.Size = new System.Drawing.Size(513, 39);
            this.SubCategoryID.TabIndex = 70;
            this.SubCategoryID.ValueMember = "ProductSubcategoryID";
            this.SubCategoryID.SelectedIndexChanged += new System.EventHandler(this.SubCategoryID_SelectedIndexChanged);
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.dB_A2ED31_itlaDataSet;
            // 
            // dB_A2ED31_itlaDataSet
            // 
            this.dB_A2ED31_itlaDataSet.DataSetName = "DB_A2ED31_itlaDataSet";
            this.dB_A2ED31_itlaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCBindingSource
            // 
            this.productCBindingSource.DataMember = "ProductC";
            this.productCBindingSource.DataSource = this.dB_A2ED31_itlaDataSet;
            // 
            // productSubcategoryBindingSource
            // 
            this.productSubcategoryBindingSource.DataMember = "ProductSubcategory";
            this.productSubcategoryBindingSource.DataSource = this.dB_A2ED31_itlaDataSet1;
            // 
            // dB_A2ED31_itlaDataSet1
            // 
            this.dB_A2ED31_itlaDataSet1.DataSetName = "DB_A2ED31_itlaDataSet";
            this.dB_A2ED31_itlaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCDataGridView
            // 
            this.productCDataGridView.AutoGenerateColumns = false;
            this.productCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn2});
            this.productCDataGridView.DataSource = this.productCBindingSource;
            this.productCDataGridView.Location = new System.Drawing.Point(0, 682);
            this.productCDataGridView.Name = "productCDataGridView";
            this.productCDataGridView.RowHeadersWidth = 102;
            this.productCDataGridView.RowTemplate.Height = 40;
            this.productCDataGridView.Size = new System.Drawing.Size(2228, 575);
            this.productCDataGridView.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductNumber";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "MakeFlag";
            this.dataGridViewCheckBoxColumn1.HeaderText = "MakeFlag";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 12;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 250;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "FinishedGoodsFlag";
            this.dataGridViewCheckBoxColumn2.HeaderText = "FinishedGoodsFlag";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 12;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn6.HeaderText = "Color";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SafetyStockLevel";
            this.dataGridViewTextBoxColumn7.HeaderText = "SafetyStockLevel";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReorderPoint";
            this.dataGridViewTextBoxColumn8.HeaderText = "ReorderPoint";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StandardCost";
            this.dataGridViewTextBoxColumn9.HeaderText = "StandardCost";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 250;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ListPrice";
            this.dataGridViewTextBoxColumn10.HeaderText = "ListPrice";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 250;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn11.HeaderText = "Size";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 250;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SizeUnitMeasureCode";
            this.dataGridViewTextBoxColumn12.HeaderText = "SizeUnitMeasureCode";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 250;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "WeightUnitMeasureCode";
            this.dataGridViewTextBoxColumn13.HeaderText = "WeightUnitMeasureCode";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 250;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn14.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 250;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DaysToManufacture";
            this.dataGridViewTextBoxColumn15.HeaderText = "DaysToManufacture";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 250;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ProductLine";
            this.dataGridViewTextBoxColumn16.HeaderText = "ProductLine";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 250;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn17.HeaderText = "Class";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 250;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Style";
            this.dataGridViewTextBoxColumn18.HeaderText = "Style";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 250;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ProductSubcategoryID";
            this.dataGridViewTextBoxColumn19.HeaderText = "ProductSubcategoryID";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 250;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ProductModelID";
            this.dataGridViewTextBoxColumn20.HeaderText = "ProductModelID";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 250;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "SellStartDate";
            this.dataGridViewTextBoxColumn21.HeaderText = "SellStartDate";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 250;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "SellEndDate";
            this.dataGridViewTextBoxColumn22.HeaderText = "SellEndDate";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 250;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "DiscontinuedDate";
            this.dataGridViewTextBoxColumn23.HeaderText = "DiscontinuedDate";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 250;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "rowguid";
            this.dataGridViewTextBoxColumn24.HeaderText = "rowguid";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 250;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn25.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductCategoryID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductCategoryID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // safetyStockLevelTextBox
            // 
            this.safetyStockLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "SafetyStockLevel", true));
            this.safetyStockLevelTextBox.Location = new System.Drawing.Point(1441, 148);
            this.safetyStockLevelTextBox.Name = "safetyStockLevelTextBox";
            this.safetyStockLevelTextBox.Size = new System.Drawing.Size(638, 38);
            this.safetyStockLevelTextBox.TabIndex = 69;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dB_A2ED31_itlaDataSet;
            // 
            // reorderPointTextBox
            // 
            this.reorderPointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "ReorderPoint", true));
            this.reorderPointTextBox.Location = new System.Drawing.Point(1441, 252);
            this.reorderPointTextBox.Name = "reorderPointTextBox";
            this.reorderPointTextBox.Size = new System.Drawing.Size(638, 38);
            this.reorderPointTextBox.TabIndex = 68;
            // 
            // daysToManufactureTextBox
            // 
            this.daysToManufactureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "DaysToManufacture", true));
            this.daysToManufactureTextBox.Location = new System.Drawing.Point(399, 571);
            this.daysToManufactureTextBox.Name = "daysToManufactureTextBox";
            this.daysToManufactureTextBox.Size = new System.Drawing.Size(531, 38);
            this.daysToManufactureTextBox.TabIndex = 67;
            // 
            // sellStartDateDateTimePicker
            // 
            this.sellStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "SellStartDate", true));
            this.sellStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "SellStartDate", true));
            this.sellStartDateDateTimePicker.Location = new System.Drawing.Point(1441, 447);
            this.sellStartDateDateTimePicker.Name = "sellStartDateDateTimePicker";
            this.sellStartDateDateTimePicker.Size = new System.Drawing.Size(638, 38);
            this.sellStartDateDateTimePicker.TabIndex = 66;
            // 
            // rowguidTextBox
            // 
            this.rowguidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "rowguid", true));
            this.rowguidTextBox.Location = new System.Drawing.Point(1441, 351);
            this.rowguidTextBox.Name = "rowguidTextBox";
            this.rowguidTextBox.Size = new System.Drawing.Size(638, 38);
            this.rowguidTextBox.TabIndex = 65;
            this.rowguidTextBox.Text = "694215B7-08F7-4C0D-ACB1-D734BA44C0C8";
            // 
            // modifiedDateDateTimePicker
            // 
            this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ModifiedDate", true));
            this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "ModifiedDate", true));
            this.modifiedDateDateTimePicker.Location = new System.Drawing.Point(1441, 533);
            this.modifiedDateDateTimePicker.Name = "modifiedDateDateTimePicker";
            this.modifiedDateDateTimePicker.Size = new System.Drawing.Size(638, 38);
            this.modifiedDateDateTimePicker.TabIndex = 64;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(289, 44);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(641, 38);
            this.productIDTextBox.TabIndex = 63;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "Name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productSubcategoryBindingSource, "ProductCategoryID", true));
            this.nameComboBox.DataSource = this.productCategoryBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.Enabled = false;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(697, 344);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(233, 39);
            this.nameComboBox.TabIndex = 62;
            this.nameComboBox.ValueMember = "ProductCategoryID";
            // 
            // standardCostTextBox
            // 
            this.standardCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "StandardCost", true));
            this.standardCostTextBox.Location = new System.Drawing.Point(741, 246);
            this.standardCostTextBox.Name = "standardCostTextBox";
            this.standardCostTextBox.Size = new System.Drawing.Size(189, 38);
            this.standardCostTextBox.TabIndex = 61;
            // 
            // listPriceTextBox
            // 
            this.listPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "ListPrice", true));
            this.listPriceTextBox.Location = new System.Drawing.Point(289, 246);
            this.listPriceTextBox.Name = "listPriceTextBox";
            this.listPriceTextBox.Size = new System.Drawing.Size(216, 38);
            this.listPriceTextBox.TabIndex = 60;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(289, 345);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(216, 38);
            this.colorTextBox.TabIndex = 59;
            // 
            // finishedGoodsFlagCheckBox
            // 
            this.finishedGoodsFlagCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "FinishedGoodsFlag", true));
            this.finishedGoodsFlagCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "MakeFlag", true));
            this.finishedGoodsFlagCheckBox.Location = new System.Drawing.Point(289, 500);
            this.finishedGoodsFlagCheckBox.Name = "finishedGoodsFlagCheckBox";
            this.finishedGoodsFlagCheckBox.Size = new System.Drawing.Size(131, 43);
            this.finishedGoodsFlagCheckBox.TabIndex = 58;
            this.finishedGoodsFlagCheckBox.Text = "checkBox1";
            this.finishedGoodsFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeFlagCheckBox
            // 
            this.makeFlagCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "MakeFlag", true));
            this.makeFlagCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "FinishedGoodsFlag", true));
            this.makeFlagCheckBox.Location = new System.Drawing.Point(786, 500);
            this.makeFlagCheckBox.Name = "makeFlagCheckBox";
            this.makeFlagCheckBox.Size = new System.Drawing.Size(144, 45);
            this.makeFlagCheckBox.TabIndex = 57;
            this.makeFlagCheckBox.Text = "checkBox1";
            this.makeFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // productNumberTextBox
            // 
            this.productNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "ProductNumber", true));
            this.productNumberTextBox.Location = new System.Drawing.Point(1441, 47);
            this.productNumberTextBox.Name = "productNumberTextBox";
            this.productNumberTextBox.Size = new System.Drawing.Size(638, 38);
            this.productNumberTextBox.TabIndex = 56;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCBindingSource, "Name1", true));
            this.nameTextBox.Location = new System.Drawing.Point(289, 142);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(641, 38);
            this.nameTextBox.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "PRODUCTOS";
            // 
            // CrearBoton
            // 
            this.CrearBoton.BackColor = System.Drawing.Color.Chartreuse;
            this.CrearBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearBoton.Location = new System.Drawing.Point(2479, 161);
            this.CrearBoton.Name = "CrearBoton";
            this.CrearBoton.Size = new System.Drawing.Size(592, 94);
            this.CrearBoton.TabIndex = 6;
            this.CrearBoton.Text = "Crear";
            this.CrearBoton.UseVisualStyleBackColor = false;
            this.CrearBoton.Click += new System.EventHandler(this.CrearBoton_Click);
            // 
            // ModificarBoton
            // 
            this.ModificarBoton.BackColor = System.Drawing.Color.Aqua;
            this.ModificarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBoton.Location = new System.Drawing.Point(2479, 330);
            this.ModificarBoton.Name = "ModificarBoton";
            this.ModificarBoton.Size = new System.Drawing.Size(592, 94);
            this.ModificarBoton.TabIndex = 7;
            this.ModificarBoton.Text = "Modificar";
            this.ModificarBoton.UseVisualStyleBackColor = false;
            this.ModificarBoton.Click += new System.EventHandler(this.ModificarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.BackColor = System.Drawing.Color.Red;
            this.EliminarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBoton.Location = new System.Drawing.Point(2479, 499);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(592, 94);
            this.EliminarBoton.TabIndex = 8;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = false;
            this.EliminarBoton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ActualizarBoton
            // 
            this.ActualizarBoton.BackColor = System.Drawing.Color.SandyBrown;
            this.ActualizarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarBoton.Location = new System.Drawing.Point(2479, 672);
            this.ActualizarBoton.Name = "ActualizarBoton";
            this.ActualizarBoton.Size = new System.Drawing.Size(592, 94);
            this.ActualizarBoton.TabIndex = 9;
            this.ActualizarBoton.Text = "Actualizar";
            this.ActualizarBoton.UseVisualStyleBackColor = false;
            this.ActualizarBoton.Click += new System.EventHandler(this.ActualizarBoton_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductSubcategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tarea_1_modulo_2.DB_A2ED31_itlaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // productCTableAdapter
            // 
            this.productCTableAdapter.ClearBeforeFill = true;
            // 
            // productSubcategoryTableAdapter
            // 
            this.productSubcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 71;
            this.label1.Text = "Categoria";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3204, 1486);
            this.Controls.Add(this.ActualizarBoton);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.ModificarBoton);
            this.Controls.Add(this.CrearBoton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2ED31_itlaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A2ED31_itlaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CrearBoton;
        private System.Windows.Forms.Button ModificarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button ActualizarBoton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DB_A2ED31_itlaDataSet dB_A2ED31_itlaDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DB_A2ED31_itlaDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DB_A2ED31_itlaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox standardCostTextBox;
        private System.Windows.Forms.TextBox listPriceTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.CheckBox finishedGoodsFlagCheckBox;
        private System.Windows.Forms.CheckBox makeFlagCheckBox;
        private System.Windows.Forms.TextBox productNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private DB_A2ED31_itlaDataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox rowguidTextBox;
        private System.Windows.Forms.DateTimePicker modifiedDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker sellStartDateDateTimePicker;
        private System.Windows.Forms.TextBox daysToManufactureTextBox;
        private System.Windows.Forms.TextBox safetyStockLevelTextBox;
        private System.Windows.Forms.TextBox reorderPointTextBox;
        private System.Windows.Forms.BindingSource productCBindingSource;
        private DB_A2ED31_itlaDataSetTableAdapters.ProductCTableAdapter productCTableAdapter;
        private System.Windows.Forms.DataGridView productCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox SubCategoryID;
        private DB_A2ED31_itlaDataSet dB_A2ED31_itlaDataSet1;
        private System.Windows.Forms.BindingSource productSubcategoryBindingSource;
        private DB_A2ED31_itlaDataSetTableAdapters.ProductSubcategoryTableAdapter productSubcategoryTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}

