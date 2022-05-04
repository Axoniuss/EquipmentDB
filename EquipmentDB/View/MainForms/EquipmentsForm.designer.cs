using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    partial class EquipmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn11 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn12 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInventoryNumber = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEquipType = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturers = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn13 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn14 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn16 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentIDDataGridViewTextBoxColumn,
            this.equipmentTypeDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.equipmentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 148);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1121, 395);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(EquipmentDB.Model.Equipment);
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.Width = 50;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "";
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn6.Width = 50;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.HeaderText = "";
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.ReadOnly = true;
            this.dataGridViewImageColumn7.Width = 30;
            // 
            // dataGridViewImageColumn8
            // 
            this.dataGridViewImageColumn8.HeaderText = "";
            this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn8.ReadOnly = true;
            this.dataGridViewImageColumn8.Width = 30;
            // 
            // dataGridViewImageColumn9
            // 
            this.dataGridViewImageColumn9.HeaderText = "";
            this.dataGridViewImageColumn9.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn9.ReadOnly = true;
            this.dataGridViewImageColumn9.Width = 30;
            // 
            // dataGridViewImageColumn10
            // 
            this.dataGridViewImageColumn10.HeaderText = "";
            this.dataGridViewImageColumn10.Name = "dataGridViewImageColumn10";
            this.dataGridViewImageColumn10.ReadOnly = true;
            this.dataGridViewImageColumn10.Width = 30;
            // 
            // dataGridViewImageColumn11
            // 
            this.dataGridViewImageColumn11.HeaderText = "";
            this.dataGridViewImageColumn11.Name = "dataGridViewImageColumn11";
            this.dataGridViewImageColumn11.ReadOnly = true;
            this.dataGridViewImageColumn11.Width = 30;
            // 
            // dataGridViewImageColumn12
            // 
            this.dataGridViewImageColumn12.HeaderText = "";
            this.dataGridViewImageColumn12.Name = "dataGridViewImageColumn12";
            this.dataGridViewImageColumn12.ReadOnly = true;
            this.dataGridViewImageColumn12.Width = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInventoryNumber);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSerialNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxEquipType);
            this.groupBox1.Controls.Add(this.comboBoxManufacturers);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск оборудования";
            // 
            // textBoxInventoryNumber
            // 
            this.textBoxInventoryNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxInventoryNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxInventoryNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxInventoryNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInventoryNumber.Location = new System.Drawing.Point(588, 40);
            this.textBoxInventoryNumber.MaxLength = 100;
            this.textBoxInventoryNumber.Name = "textBoxInventoryNumber";
            this.textBoxInventoryNumber.Size = new System.Drawing.Size(258, 20);
            this.textBoxInventoryNumber.TabIndex = 10;
            this.textBoxInventoryNumber.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Image = global::EquipmentDB.Properties.Resources.search_24;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(852, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(263, 49);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.toolTip1.SetToolTip(this.buttonSearch, "Поиск оборудования по заданнм параметрам");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReset.FlatAppearance.BorderSize = 2;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Image = global::EquipmentDB.Properties.Resources.refresh_16;
            this.buttonReset.Location = new System.Drawing.Point(852, 83);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(263, 29);
            this.buttonReset.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonReset, "Сброс параметров и данных поиска");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Инвентарный номер";
            // 
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Наименование оборудования";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSerialNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSerialNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialNumber.Location = new System.Drawing.Point(304, 82);
            this.textBoxSerialNumber.MaxLength = 100;
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(258, 20);
            this.textBoxSerialNumber.TabIndex = 10;
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Серийный номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Тип учёта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Тип оборудования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Изготовитель";
            // 
            // 
            // 
            // comboBoxEquipType
            // 
            this.comboBoxEquipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipType.FormattingEnabled = true;
            this.comboBoxEquipType.Location = new System.Drawing.Point(20, 82);
            this.comboBoxEquipType.Name = "comboBoxEquipType";
            this.comboBoxEquipType.Size = new System.Drawing.Size(258, 21);
            this.comboBoxEquipType.TabIndex = 6;
            // 
            // comboBoxManufacturers
            // 
            this.comboBoxManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturers.FormattingEnabled = true;
            this.comboBoxManufacturers.Location = new System.Drawing.Point(20, 40);
            this.comboBoxManufacturers.Name = "comboBoxManufacturers";
            this.comboBoxManufacturers.Size = new System.Drawing.Size(258, 21);
            this.comboBoxManufacturers.TabIndex = 6;
            // 
            // dataGridViewImageColumn13
            // 
            this.dataGridViewImageColumn13.DataPropertyName = "Room_ID";
            this.dataGridViewImageColumn13.HeaderText = "";
            this.dataGridViewImageColumn13.Image = global::EquipmentDB.Properties.Resources.edit_16;
            this.dataGridViewImageColumn13.Name = "dataGridViewImageColumn13";
            this.dataGridViewImageColumn13.ReadOnly = true;
            this.dataGridViewImageColumn13.ToolTipText = "Редактировать помещение";
            this.dataGridViewImageColumn13.Width = 30;
            // 
            // dataGridViewImageColumn14
            // 
            this.dataGridViewImageColumn14.HeaderText = "";
            this.dataGridViewImageColumn14.Image = global::EquipmentDB.Properties.Resources.delete_16;
            this.dataGridViewImageColumn14.Name = "dataGridViewImageColumn14";
            this.dataGridViewImageColumn14.ReadOnly = true;
            this.dataGridViewImageColumn14.ToolTipText = "Редактировать помещение";
            this.dataGridViewImageColumn14.Width = 30;
            // 
            // dataGridViewImageColumn15
            // 
            this.dataGridViewImageColumn15.HeaderText = "";
            this.dataGridViewImageColumn15.Image = global::EquipmentDB.Properties.Resources.delete_16;
            this.dataGridViewImageColumn15.Name = "dataGridViewImageColumn15";
            this.dataGridViewImageColumn15.ReadOnly = true;
            this.dataGridViewImageColumn15.ToolTipText = "Удалить помещение";
            this.dataGridViewImageColumn15.Visible = false;
            this.dataGridViewImageColumn15.Width = 30;
            // 
            // dataGridViewImageColumn16
            // 
            this.dataGridViewImageColumn16.HeaderText = "";
            this.dataGridViewImageColumn16.Image = global::EquipmentDB.Properties.Resources.check_16;
            this.dataGridViewImageColumn16.Name = "dataGridViewImageColumn16";
            this.dataGridViewImageColumn16.Visible = false;
            this.dataGridViewImageColumn16.Width = 30;
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "Equipment_ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.equipmentIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.equipmentIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // equipmentTypeDataGridViewTextBoxColumn
            // 
            this.equipmentTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.equipmentTypeDataGridViewTextBoxColumn.DataPropertyName = "EquipmentType";
            this.equipmentTypeDataGridViewTextBoxColumn.HeaderText = "Тип ";
            this.equipmentTypeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.equipmentTypeDataGridViewTextBoxColumn.Name = "equipmentTypeDataGridViewTextBoxColumn";
            this.equipmentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.manufacturerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 

            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "б/н";
            this.serialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.serialDataGridViewTextBoxColumn.HeaderText = "Серийный №";
            this.serialDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialDataGridViewTextBoxColumn.Width = 80;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инвентарный №";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Availability";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "На складе";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Всего";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 60;
            // 
            // EquipmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "EquipmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор оборудования";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn11;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn13;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxManufacturers;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn15;
        private System.Windows.Forms.TextBox textBoxInventoryNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEquipType;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn16;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}