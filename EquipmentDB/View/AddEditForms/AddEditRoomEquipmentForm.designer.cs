namespace EquipmentDB.Forms.AddEditForms
{
    partial class AddEditRoomEquipmentForm
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
            this.buttonAddEdit = new System.Windows.Forms.Button();

            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEquip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearchEquipment = new System.Windows.Forms.Button();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelAva = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
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
            this.buttonAddEdit.Location = new System.Drawing.Point(24, 365);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(152, 34);
            this.buttonAddEdit.TabIndex = 2;
            this.buttonAddEdit.Text = "Добавить";
            this.buttonAddEdit.UseVisualStyleBackColor = false;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
     
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер гимназии";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Помещение";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(21, 92);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(355, 23);
            this.comboBoxRoom.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 146);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 21);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // textBoxEquip
            // 
            this.textBoxEquip.Location = new System.Drawing.Point(21, 236);
            this.textBoxEquip.Multiline = true;
            this.textBoxEquip.Name = "textBoxEquip";
            this.textBoxEquip.ReadOnly = true;
            this.textBoxEquip.Size = new System.Drawing.Size(355, 90);
            this.textBoxEquip.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Инветарный номер";
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
            this.buttonCancel.Location = new System.Drawing.Point(215, 365);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(152, 34);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSearchEquipment
            // 
            this.buttonSearchEquipment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearchEquipment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearchEquipment.FlatAppearance.BorderSize = 2;
            this.buttonSearchEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchEquipment.Image = global::EquipmentDB.Properties.Resources.search_24;
            this.buttonSearchEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchEquipment.Location = new System.Drawing.Point(21, 196);
            this.buttonSearchEquipment.Name = "buttonSearchEquipment";
            this.buttonSearchEquipment.Size = new System.Drawing.Size(355, 34);
            this.buttonSearchEquipment.TabIndex = 2;
            this.buttonSearchEquipment.Text = "Поиск оборудования";
            this.buttonSearchEquipment.UseVisualStyleBackColor = false;
            this.buttonSearchEquipment.Click += new System.EventHandler(this.buttonSearchEquipment_Click);
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInventory.Location = new System.Drawing.Point(160, 336);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(12, 15);
            this.labelInventory.TabIndex = 6;
            this.labelInventory.Text = "-";
            // 
            // labelAva
            // 
            this.labelAva.AutoSize = true;
            this.labelAva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAva.Location = new System.Drawing.Point(227, 148);
            this.labelAva.Name = "labelAva";
            this.labelAva.Size = new System.Drawing.Size(12, 15);
            this.labelAva.TabIndex = 6;
            this.labelAva.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(100, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Кол-во на складе:";
            // 
            // AddEditRoomEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelAva);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEquip);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearchEquipment);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditRoomEquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEquip;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Button buttonSearchEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAva;
    }
}