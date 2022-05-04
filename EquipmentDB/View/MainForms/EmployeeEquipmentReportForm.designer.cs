using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    partial class EmployeeEquipmentReportForm
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
            this.employeeEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.button1 = new System.Windows.Forms.Button();
            this.employeeEquipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEquipmentBindingSource)).BeginInit();
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
            this.employeeEquipmentIDDataGridViewTextBoxColumn,
            this.equipmentDataGridViewTextBoxColumn,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.DateIssue,
            this.DateReturn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.employeeEquipmentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 52);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(912, 424);
            this.dataGridView.TabIndex = 2;
            // 
            // employeeEquipmentBindingSource
            // 
            this.employeeEquipmentBindingSource.DataSource = typeof(EquipmentDB.Model.EmployeeEquipment);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EquipmentDB.Properties.Resources.Word;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Экспорт в файл";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // employeeEquipmentIDDataGridViewTextBoxColumn
            // 
            this.employeeEquipmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.employeeEquipmentIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeEquipment_ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeeEquipmentIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.employeeEquipmentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.employeeEquipmentIDDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.employeeEquipmentIDDataGridViewTextBoxColumn.Name = "employeeEquipmentIDDataGridViewTextBoxColumn";
            this.employeeEquipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeEquipmentIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // equipmentDataGridViewTextBoxColumn
            // 
            this.equipmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentDataGridViewTextBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.HeaderText = "Оборудование";
            this.equipmentDataGridViewTextBoxColumn.MinimumWidth = 199;
            this.equipmentDataGridViewTextBoxColumn.Name = "equipmentDataGridViewTextBoxColumn";
            this.equipmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Инвентарный номер";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "б/н";
            this.serialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.serialDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.serialDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialDataGridViewTextBoxColumn.Width = 70;
            // 
            // DateIssue
            // 
            this.DateIssue.DataPropertyName = "DateIssue";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.DateIssue.DefaultCellStyle = dataGridViewCellStyle5;
            this.DateIssue.HeaderText = "Дата выдачи";
            this.DateIssue.Name = "DateIssue";
            this.DateIssue.ReadOnly = true;
            this.DateIssue.Width = 80;
            // 
            // DateReturn
            // 
            this.DateReturn.DataPropertyName = "DateReturn";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.DateReturn.DefaultCellStyle = dataGridViewCellStyle6;
            this.DateReturn.HeaderText = "Дата возврата";
            this.DateReturn.Name = "DateReturn";
            this.DateReturn.ReadOnly = true;
            this.DateReturn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // EmployeeEquipmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Name = "EmployeeEquipmentReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование во временном использовании сотрудника";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEquipmentBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource employeeEquipmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEquipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}