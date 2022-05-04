namespace EquipmentDB.Forms.AddEditForms
{
    partial class AddEditEquipmentForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.comboBoxEquipType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.textBoxInventoryNumber = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label84 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.textBoxNotice = new System.Windows.Forms.TextBox();
            this.buttonAddManufacturer = new System.Windows.Forms.Button();
            this.buttonAddEquipType = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::EquipmentDB.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(289, 476);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(151, 34);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddEdit.FlatAppearance.BorderSize = 2;
            this.buttonAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEdit.Location = new System.Drawing.Point(22, 476);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(151, 34);
            this.buttonAddEdit.TabIndex = 10;
            this.buttonAddEdit.Text = "Сохранить";
            this.buttonAddEdit.UseVisualStyleBackColor = false;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // comboBoxEquipType
            // 
            this.comboBoxEquipType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEquipType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEquipType.FormattingEnabled = true;
            this.comboBoxEquipType.Location = new System.Drawing.Point(24, 32);
            this.comboBoxEquipType.Name = "comboBoxEquipType";
            this.comboBoxEquipType.Size = new System.Drawing.Size(397, 23);
            this.comboBoxEquipType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип оборудования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фирма производитель";
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(24, 82);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(397, 23);
            this.comboBoxManufacturer.TabIndex = 2;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(22, 177);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(106, 15);
            this.label64.TabIndex = 0;
            this.label64.Text = "Серийный номер";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerial.Location = new System.Drawing.Point(22, 198);
            this.textBoxSerial.MaxLength = 50;
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(420, 21);
            this.textBoxSerial.TabIndex = 6;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(22, 225);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(128, 15);
            this.label74.TabIndex = 0;
            this.label74.Text = "Инвентарный номер";
            // 
            // textBoxInventoryNumber
            // 
            this.textBoxInventoryNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxInventoryNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxInventoryNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxInventoryNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInventoryNumber.Location = new System.Drawing.Point(22, 246);
            this.textBoxInventoryNumber.MaxLength = 50;
            this.textBoxInventoryNumber.Name = "textBoxInventoryNumber";
            this.textBoxInventoryNumber.Size = new System.Drawing.Size(420, 21);
            this.textBoxInventoryNumber.TabIndex = 7;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(24, 298);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownQuantity.TabIndex = 8;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(24, 277);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(76, 15);
            this.label84.TabIndex = 0;
            this.label84.Text = "Количество";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(177, 335);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(89, 15);
            this.label94.TabIndex = 0;
            this.label94.Text = "Комментарий";
            // 
            // textBoxNotice
            // 
            this.textBoxNotice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNotice.Location = new System.Drawing.Point(22, 353);
            this.textBoxNotice.MaxLength = 100;
            this.textBoxNotice.Multiline = true;
            this.textBoxNotice.Name = "textBoxNotice";
            this.textBoxNotice.Size = new System.Drawing.Size(420, 113);
            this.textBoxNotice.TabIndex = 9;
            // 
            // buttonAddManufacturer
            // 
            this.buttonAddManufacturer.Location = new System.Drawing.Point(427, 82);
            this.buttonAddManufacturer.Name = "buttonAddManufacturer";
            this.buttonAddManufacturer.Size = new System.Drawing.Size(22, 23);
            this.buttonAddManufacturer.TabIndex = 12;
            this.buttonAddManufacturer.Text = "+";
            this.buttonAddManufacturer.UseVisualStyleBackColor = true;
            this.buttonAddManufacturer.Click += new System.EventHandler(this.buttonAddManufacturer_Click);
            // 
            // buttonAddEquipType
            // 
            this.buttonAddEquipType.Location = new System.Drawing.Point(427, 32);
            this.buttonAddEquipType.Name = "buttonAddEquipType";
            this.buttonAddEquipType.Size = new System.Drawing.Size(22, 23);
            this.buttonAddEquipType.TabIndex = 12;
            this.buttonAddEquipType.Text = "+";
            this.buttonAddEquipType.UseVisualStyleBackColor = true;
            this.buttonAddEquipType.Click += new System.EventHandler(this.buttonAddEquipType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Модель";
            // 
            // textBoxModel
            // 
            this.textBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModel.Location = new System.Drawing.Point(24, 138);
            this.textBoxModel.MaxLength = 200;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(419, 21);
            this.textBoxModel.TabIndex = 4;
            // 
            // AddEditEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 522);
            this.Controls.Add(this.buttonAddEquipType);
            this.Controls.Add(this.buttonAddManufacturer);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxEquipType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNotice);
            this.Controls.Add(this.textBoxInventoryNumber);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.label94);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditEquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddEditPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.ComboBox comboBoxEquipType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox textBoxInventoryNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.TextBox textBoxNotice;
        private System.Windows.Forms.Button buttonAddEquipType;
        private System.Windows.Forms.Button buttonAddManufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxModel;
    }
}