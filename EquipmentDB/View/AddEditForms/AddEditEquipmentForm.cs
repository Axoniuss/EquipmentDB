using EquipmentDB.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditEquipmentForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private Equipment _item;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditEquipmentForm(Equipment item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditEquipmentForm()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            var balanceType = comboBoxBalanceType.SelectedItem as BalanceType;
            var equipType = comboBoxEquipType.SelectedItem as EquipmentType;
            var manufacturer = comboBoxManufacturer.SelectedItem as Manufacturer;

            
            if (equipType==null)
            {
                MessageBox.Show("Не выбран тип оборудования!");
                return false;
            }
            if (manufacturer == null)
            {
                MessageBox.Show("Не выбрана фирма изготовитель оборудования!");
                return false;
            }
            if (balanceType != null &&
                balanceType.BalanceType_ID == 1 &&
                string.IsNullOrWhiteSpace(textBoxInventoryNumber.Text))
            {
                MessageBox.Show("При добавлении оборудования на балансный учёт необхидом указать инвентарный номер!",
                    "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (equipType.EquipmentType_ID == 0 && manufacturer.Manufacturer_ID == 0 && string.IsNullOrWhiteSpace(textBoxEquipName.Text))
            {
                MessageBox.Show("Укажите наименование или модель оборудования, так как не указан тип оборудования и фирма производитель!",
                    "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            return true;
        }


        #region Обработчики событий

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            try
            {
                var manufacturer = comboBoxManufacturer.SelectedItem as Manufacturer;
                var equipType = comboBoxEquipType.SelectedItem as EquipmentType;
                if (_edit)
                {
                    EditItem(manufacturer, equipType);
                }
                else
                {
                    AddItem(manufacturer, equipType);
                }
                Close();
            }
            catch (Exception exception)
            {
                _repository.HandleException(exception);
            }
        }

        private void AddEditPostForm_Load(object sender, EventArgs e)
        {

            //--------------------------------------------------
            comboBoxBalanceType.DataSource = _repository.GetEntityes<BalanceType>();
            InitComboBoxes("all");
            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                comboBoxManufacturer.SelectedItem = _item.Manufacturer;
                comboBoxEquipType.SelectedItem = _item.EquipmentType;

                comboBoxBalanceType.SelectedItem = _item.BalanceType;
                textBoxEquipName.Text = _item.EquipmentName;
                numericUpDownQuantity.Value = _item.Quantity;
                textBoxSerial.Text = _item.Serial;
                textBoxInventoryNumber.Text = _item.InventoryNumber;
                textBoxNotice.Text = _item.Notice;
                textBoxModel.Text = _item.Model;

                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }

            #region Загрузка автодополнения для textBox

            AutoCompleteLoad();

            #endregion
        }

        #endregion

        #region Приватные методы

        /// <summary>
        /// Инициализация данных combobox
        /// </summary>
        private void InitComboBoxes(string name)
        {
            if (name == "comboBoxEquipType" || name == "all")
            {
                var equipTypes = new List<EquipmentType> { new EquipmentType() { EquipmentTypeName = "Нет типа оборудования" } };
                equipTypes.AddRange(_repository.GetEntityes<EquipmentType>());
                comboBoxEquipType.DataSource = equipTypes;
                comboBoxEquipType.SelectedItem = equipTypes.First();
            }

            if (name == "comboBoxManufacturer" || name == "all")
            {
                //--------------------------------------------------
                var manufacturers = new List<Manufacturer> { new Manufacturer() { ManufacturerName = "Нет производителя" } };
                manufacturers.AddRange(_repository.GetEntityes<Manufacturer>());
                comboBoxManufacturer.DataSource = manufacturers;
                comboBoxManufacturer.SelectedItem = manufacturers.First();
            }
        }

        /// <summary>
        /// Метод сохранения редактирования
        /// </summary>
        private void EditItem(Manufacturer manufacturer, EquipmentType equipType)
        {
            _item.Manufacturer_ID = manufacturer.Manufacturer_ID == 0 ? (int?)null : manufacturer.Manufacturer_ID;
            _item.EquipmentType_ID = equipType.EquipmentType_ID == 0 ? (int?)null : equipType.EquipmentType_ID;

            _item.BalanceType_ID = (comboBoxBalanceType.SelectedItem as BalanceType).BalanceType_ID;
            _item.EquipmentName = textBoxEquipName.Text;
            _item.Quantity = (int)numericUpDownQuantity.Value;
            _item.Serial = string.IsNullOrWhiteSpace(textBoxSerial.Text) ? "б/н" : textBoxSerial.Text;
            _item.InventoryNumber = textBoxInventoryNumber.Text;
            _item.Notice = textBoxNotice.Text;
            _item.Model = textBoxModel.Text;

            if (_item.Quantity < _item.RoomEquipmentsQuantity + _item.EmployeeEquipmentsQuantity + _item.WriteOffEquipmentsQuantity)
            {
                throw new InvalidOperationException("Неверно указано количество единиц оборудования!");
            }

            _item.Manufacturer = null;
            _item.EquipmentType = null;
            _item.BalanceType = null;
            _item.EmployeeEquipments = null;
            _item.RoomEquipments = null;
            _item.WriteOffEquipments = null;


            _repository.UpdateEntity(_item);
        }

        /// <summary>
        /// Метод добавления нового оборудования
        /// </summary>
        private void AddItem(Manufacturer manufacturer, EquipmentType equipType)
        {
            _item = new Equipment()
            {
                Manufacturer_ID = manufacturer.Manufacturer_ID == 0 ? (int?)null : manufacturer.Manufacturer_ID,
                EquipmentType_ID = equipType.EquipmentType_ID == 0 ? (int?)null : equipType.EquipmentType_ID,
                BalanceType_ID = (comboBoxBalanceType.SelectedItem as BalanceType).BalanceType_ID,
                EquipmentName = textBoxEquipName.Text,
                Quantity = (int)numericUpDownQuantity.Value,
                Serial = string.IsNullOrWhiteSpace(textBoxSerial.Text) ? "б/н" : textBoxSerial.Text,
                InventoryNumber = textBoxInventoryNumber.Text,
                Notice = textBoxNotice.Text,
                Model = textBoxModel.Text

            };
            _repository.AddEntity(_item);
        }

        #endregion

        private void buttonAddEquipType_Click(object sender, EventArgs e)
        {
            var et = new AddEditEquipmentTypeForm();
            et.ShowDialog();
            InitComboBoxes("comboBoxEquipType");
            comboBoxEquipType.SelectedItem = et.EquipmentType;
        }

        private void buttonAddManufacturer_Click(object sender, EventArgs e)
        {
            var m = new AddEditManufacturerForm();
            m.ShowDialog();
            InitComboBoxes("comboBoxManufacturer");
            comboBoxManufacturer.SelectedItem = m.Manufacturer;
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            var balanceType = comboBoxBalanceType.SelectedItem as BalanceType;
            if (balanceType?.BalanceType_ID == 1 && numericUpDownQuantity.Value > 1)
            {
                MessageBox.Show(" Добавление оборудования на балансный учёт возможно только в единичном экземпляре!",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownQuantity.Value = 1;
            }
        }

        private async void AutoCompleteLoad()
        {
            var resultTask = Task.Run(() =>
            {
                var autoCompleteEquipName = new AutoCompleteStringCollection();
                autoCompleteEquipName.AddRange(_repository.GetEntityes<Equipment>().
                    Where(eq => eq.EquipmentName != null && eq.EquipmentName.ToLower().Contains(textBoxEquipName.Text.ToLower())).Select(eq => eq.EquipmentName).ToArray());
                return autoCompleteEquipName;
            });
            var equipNameList = await resultTask;
            textBoxEquipName.AutoCompleteCustomSource = equipNameList;


            var resultTask2 = Task.Run(() =>
            {
                var autoCompleteInventoryName = new AutoCompleteStringCollection();
                autoCompleteInventoryName.AddRange(_repository.GetEntityes<Equipment>().
                    Where(eq => eq.InventoryNumber != null && eq.InventoryNumber.ToLower().Contains(textBoxInventoryNumber.Text.ToLower())).Select(eq => eq.InventoryNumber).ToArray());
                return autoCompleteInventoryName;
            });
            var inventoryList = await resultTask2;
            textBoxInventoryNumber.AutoCompleteCustomSource = inventoryList;


            var resultTask3 = Task.Run(() =>
            {
                var autoCompleteInventoryName = new AutoCompleteStringCollection();
                autoCompleteInventoryName.AddRange(_repository.GetEntityes<Equipment>().
                    Where(eq => eq.Model != null && eq.Model.ToLower().Contains(textBoxModel.Text.ToLower())).Select(eq => eq.Model).ToArray());
                return autoCompleteInventoryName;
            });
            var modelList = await resultTask3;
            textBoxModel.AutoCompleteCustomSource = modelList;

        }

    }
}
