using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    partial class RoomPassportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewEquipments = new System.Windows.Forms.DataGridView();
            this.roomEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn11 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn12 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn13 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn14 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipInventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRoomBindingSource)).BeginInit();
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
            // dataGridViewEquipments
            // 
            this.dataGridViewEquipments.AllowUserToAddRows = false;
            this.dataGridViewEquipments.AllowUserToDeleteRows = false;
            this.dataGridViewEquipments.AllowUserToOrderColumns = true;
            this.dataGridViewEquipments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewEquipments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEquipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEquipments.AutoGenerateColumns = false;
            this.dataGridViewEquipments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEquipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentIDDataGridViewTextBoxColumn,
            this.equipmentDataGridViewTextBoxColumn,
            this.equipInventoryNumberDataGridViewTextBoxColumn,
            this.dateOfIssueDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridViewEquipments.DataSource = this.roomEquipmentBindingSource;
            this.dataGridViewEquipments.Location = new System.Drawing.Point(12, 249);
            this.dataGridViewEquipments.MultiSelect = false;
            this.dataGridViewEquipments.Name = "dataGridViewEquipments";
            this.dataGridViewEquipments.ReadOnly = true;
            this.dataGridViewEquipments.RowHeadersVisible = false;
            this.dataGridViewEquipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEquipments.Size = new System.Drawing.Size(682, 273);
            this.dataGridViewEquipments.TabIndex = 2;
            this.dataGridViewEquipments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridViewEquipments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipments_CellContentClick);
            // 
            // roomEquipmentBindingSource
            // 
            this.roomEquipmentBindingSource.DataSource = typeof(EquipmentDB.Model.RoomEquipment);
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
            // dataGridViewImageColumn13
            // 
            this.dataGridViewImageColumn13.DataPropertyName = "Room_ID";
            this.dataGridViewImageColumn13.HeaderText = "";
            this.dataGridViewImageColumn13.Image = global::EquipmentDB.Properties.Resources.edit_16;
            this.dataGridViewImageColumn13.Name = "dataGridViewImageColumn13";
            this.dataGridViewImageColumn13.ReadOnly = true;
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
            this.dataGridViewImageColumn15.Width = 30;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AllowUserToOrderColumns = true;
            this.dataGridViewEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridViewEmployees.DataSource = this.employeeRoomBindingSource;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(682, 166);
            this.dataGridViewEmployees.TabIndex = 2;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeeIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата назначения";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 118;
            // 
            // employeeRoomBindingSource
            // 
            this.employeeRoomBindingSource.DataSource = typeof(EquipmentDB.Model.EmployeeRoom);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPrint.FlatAppearance.BorderSize = 2;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Image = global::EquipmentDB.Properties.Resources.Word;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrint.Location = new System.Drawing.Point(488, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(206, 33);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Экспорт: Паспорт помещения";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оборудование закреплённое за помещением";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сотрудники ответственные за помещение";
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
            // equipmentDataGridViewTextBoxColumn
            // 
            this.equipmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentDataGridViewTextBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.HeaderText = "Наименование оборудования";
            this.equipmentDataGridViewTextBoxColumn.Name = "equipmentDataGridViewTextBoxColumn";
            this.equipmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipInventoryNumberDataGridViewTextBoxColumn
            // 
            this.equipInventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "EquipInventoryNumber";
            this.equipInventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инвентарный №";
            this.equipInventoryNumberDataGridViewTextBoxColumn.Name = "equipInventoryNumberDataGridViewTextBoxColumn";
            this.equipInventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfIssueDataGridViewTextBoxColumn
            // 
            this.dateOfIssueDataGridViewTextBoxColumn.DataPropertyName = "DateOfIssue";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dateOfIssueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateOfIssueDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.dateOfIssueDataGridViewTextBoxColumn.Name = "dateOfIssueDataGridViewTextBoxColumn";
            this.dateOfIssueDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfIssueDataGridViewTextBoxColumn.Width = 70;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // RoomPassportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.dataGridViewEquipments);
            this.Name = "RoomPassportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Паспорт помещения";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridView dataGridViewEquipments;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn11;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn13;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn14;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn15;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.BindingSource roomEquipmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeRoomBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipInventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}