using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.MainForms;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditEmployeeEquipmentForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        /// <summary>
        /// Выданное оборудование
        /// </summary>
        private EmployeeEquipment _item;

        /// <summary>
        /// Выдача оборудования
        /// </summary>
        private readonly EquipmentLeasing _equipmentLeasing;

        /// <summary>
        /// Выбранное оборудование
        /// </summary>
        private Equipment _selectedEquipment;

        private readonly bool _edit;

        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditEmployeeEquipmentForm(EmployeeEquipment item)
        {
            _equipmentLeasing = item.EquipmentLeasing;
            _selectedEquipment = item.Equipment;
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditEmployeeEquipmentForm(EquipmentLeasing equipmentLeasing)
        {
            _equipmentLeasing = equipmentLeasing;
            InitializeComponent();
        }

        private bool Check()
        {
            if (_selectedEquipment == null)
            {
                MessageBox.Show(@"Не выбрано выдаваемое оборудование", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (_edit &&
                _selectedEquipment != null &&
                _selectedEquipment.Availability + _item.Quantity - (int)numericUpDown1.Value < 0)
            {
                MessageBox.Show(@"Данное оборудование отсутсвует на складе в нужном количестве", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (!_edit && _selectedEquipment != null && _selectedEquipment.Availability - (int)numericUpDown1.Value < 0)
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
                    _item.EquipmentLeasing_ID = _equipmentLeasing.EquipmentLeasing_ID;
                    _item.Equipment_ID = _selectedEquipment.Equipment_ID;
                    _item.Quantity = (int)numericUpDown1.Value;


                    _item.Equipment = null;
                    _item.EquipmentLeasing = null;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new EmployeeEquipment()
                    {
                        EquipmentLeasing_ID = _equipmentLeasing.EquipmentLeasing_ID,
                        Equipment_ID = _selectedEquipment.Equipment_ID,
                        Quantity = (int)numericUpDown1.Value

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
            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                _selectedEquipment = _item.Equipment;
                numericUpDown1.Value = _item.Quantity;
                textBoxEquipment.Text = _selectedEquipment.ToString();
                labelEqAvailable.Text = _selectedEquipment.Availability.ToString();
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки поиска сотрудника
        /// </summary>
        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            var eqForm = new EquipmentsForm();
            if (eqForm.ShowDialog() == DialogResult.OK)
            {
                _selectedEquipment = eqForm.SelectedEquipment;
                textBoxEquipment.Text = _selectedEquipment.ToString();
                labelEqAvailable.Text = _selectedEquipment.Availability.ToString();

            }
        }




    }
}
