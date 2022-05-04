using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.MainForms;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditWriteOffEquipmentForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private WriteOffEquipment _item;

        private readonly bool _edit;

        private Equipment _selectedEquipment;
        
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditWriteOffEquipmentForm(WriteOffEquipment item)
        {
            _item = item;
            _edit = true;
            _selectedEquipment = item.Equipment;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления с таблицы оборудования
        /// </summary>
        public AddEditWriteOffEquipmentForm(Equipment equipment)
        {
            _selectedEquipment = equipment;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditWriteOffEquipmentForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (_selectedEquipment==null)
            {
                MessageBox.Show(@"Не выбрано списываемое оборудование" + label1.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxOrderNumber.Text))
            {
                MessageBox.Show(@"Не заполнено поле " + label2.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (_edit &&
                _selectedEquipment != null &&
                _selectedEquipment.Availability + _item.Quantity - (int)numericUpDown.Value < 0)
            {
                MessageBox.Show(@"Данное оборудование отсутсвует на складе в нужном количестве", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (!_edit && _selectedEquipment != null && _selectedEquipment.Availability - (int)numericUpDown.Value < 0)
            {
                MessageBox.Show(@"Данное оборудование отсутсвует на складе в нужном количестве", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            if (!Check()) return;
            try
            {
                if (_edit)
                {
                    _item.Equipment_ID = _selectedEquipment.Equipment_ID;
                    _item.OrderNumber = textBoxOrderNumber.Text;
                    _item.OrderDate = dateTimePicker.Value.Date;
                    _item.Quantity =(int) numericUpDown.Value;

                    _item.Equipment = null;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new WriteOffEquipment
                    {
                        Equipment_ID = _selectedEquipment.Equipment_ID,
                        OrderNumber = textBoxOrderNumber.Text,
                        OrderDate = dateTimePicker.Value.Date,
                        Quantity =(int) numericUpDown.Value
                    };
                    _repository.AddEntity(_item);
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
            if (_selectedEquipment != null)
            {
                textBoxEquipName.Text = _selectedEquipment.ToString();
                labelInventoryNumber.Text = _selectedEquipment.InventoryNumber;
                labelAvailability.Text = _selectedEquipment.Availability.ToString();
            }
           
            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                textBoxEquipName.Text = _item.Equipment.ToString();
               
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }
        

        private void checkInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxOrderNumber,
                string.IsNullOrWhiteSpace(textBoxOrderNumber.Text) ? "Поле не заполнено" : string.Empty);
        }

        /// <summary>
        /// Обработка события нажатия кнопки поиска оборудования
        /// </summary>
        private void buttonSearchEquipment_Click(object sender, EventArgs e)
        {
            var equipForm = new EquipmentsForm();

            if (equipForm.ShowDialog() != DialogResult.OK) return;

            _selectedEquipment = equipForm.SelectedEquipment;
            textBoxEquipName.Text = _selectedEquipment.ToString();
            labelInventoryNumber.Text = _selectedEquipment.InventoryNumber;
            labelAvailability.Text = _selectedEquipment.Availability.ToString();
        }
    }
}
