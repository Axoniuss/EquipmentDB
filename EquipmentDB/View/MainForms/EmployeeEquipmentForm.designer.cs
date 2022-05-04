using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    partial class EmployeeEquipmentForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCurrentEmp = new System.Windows.Forms.Label();
            this.labelInEmp = new System.Windows.Forms.Label();
            this.labelDateIssue = new System.Windows.Forms.Label();
            this.labelDateReturn = new System.Windows.Forms.Label();
            this.Equipment_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.Equipment_ID,
            this.equipmentDataGridViewTextBoxColumn,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.dataGridView.DataSource = this.employeeEquipmentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 155);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(831, 321);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
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
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::EquipmentDB.Properties.Resources.add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(12, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(831, 33);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выдающий оборудование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Принимающий оборудование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата выдачи:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(195, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата возврата:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EquipmentDB.Properties.Resources.Word;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(634, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Экспорт: Акт приема-передачи";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelCurrentEmp
            // 
            this.labelCurrentEmp.AutoSize = true;
            this.labelCurrentEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentEmp.Location = new System.Drawing.Point(195, 11);
            this.labelCurrentEmp.Name = "labelCurrentEmp";
            this.labelCurrentEmp.Size = new System.Drawing.Size(155, 15);
            this.labelCurrentEmp.TabIndex = 4;
            this.labelCurrentEmp.Text = "Выдающий оборудование";
            // 
            // labelInEmp
            // 
            this.labelInEmp.AutoSize = true;
            this.labelInEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInEmp.Location = new System.Drawing.Point(195, 38);
            this.labelInEmp.Name = "labelInEmp";
            this.labelInEmp.Size = new System.Drawing.Size(177, 15);
            this.labelInEmp.TabIndex = 4;
            this.labelInEmp.Text = "Принимающий оборудование";
            // 
            // labelDateIssue
            // 
            this.labelDateIssue.AutoSize = true;
            this.labelDateIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateIssue.Location = new System.Drawing.Point(94, 69);
            this.labelDateIssue.Name = "labelDateIssue";
            this.labelDateIssue.Size = new System.Drawing.Size(86, 15);
            this.labelDateIssue.TabIndex = 4;
            this.labelDateIssue.Text = "Дата выдачи:";
            // 
            // labelDateReturn
            // 
            this.labelDateReturn.AutoSize = true;
            this.labelDateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateReturn.Location = new System.Drawing.Point(291, 69);
            this.labelDateReturn.Name = "labelDateReturn";
            this.labelDateReturn.Size = new System.Drawing.Size(98, 15);
            this.labelDateReturn.TabIndex = 4;
            this.labelDateReturn.Text = "Дата возврата:";
            // 
            // Equipment_ID
            // 
            this.Equipment_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Equipment_ID.DataPropertyName = "Equipment_ID";
            this.Equipment_ID.HeaderText = "ID обруд.";
            this.Equipment_ID.MinimumWidth = 60;
            this.Equipment_ID.Name = "Equipment_ID";
            this.Equipment_ID.ReadOnly = true;
            this.Equipment_ID.Width = 60;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "б/н";
            this.serialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.serialDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.serialDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialDataGridViewTextBoxColumn.Width = 70;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::EquipmentDB.Properties.Resources.edit_16;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.ToolTipText = "Редактировать помещение";
            this.EditColumn.Width = 30;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::EquipmentDB.Properties.Resources.iconfinder_reply_4295560;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.ToolTipText = "Вернуть оборудование на склад";
            this.DeleteColumn.Width = 30;
            // 
            // EmployeeEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 488);
            this.Controls.Add(this.labelDateReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDateIssue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInEmp);
            this.Controls.Add(this.labelCurrentEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "EmployeeEquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование во временном использовании";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEquipmentBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn11;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn13;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn14;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCurrentEmp;
        private System.Windows.Forms.Label labelInEmp;
        private System.Windows.Forms.Label labelDateIssue;
        private System.Windows.Forms.Label labelDateReturn;
        private System.Windows.Forms.BindingSource employeeEquipmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}