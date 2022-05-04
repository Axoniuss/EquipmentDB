using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.MainForms;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditRoomEquipmentForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private RoomEquipment _item;

        private readonly bool _edit;

        private Equipment _selectedEquipment;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditRoomEquipmentForm(RoomEquipment item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditRoomEquipmentForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            //Проверка наполненности поля: Помещение
            if (comboBoxRoom.SelectedItem == null)
            {
                MessageBox.Show(@"Не выбрано помещение", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            //Проверка наполненности поля: Оборудование
            if (_selectedEquipment == null)
            {
                MessageBox.Show(@"Не выбрано оборудование", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            //Контроль проверки наличия оборудования на складе
            if (_edit&&
                _selectedEquipment != null &&
                _selectedEquipment.Availability+_item.Quantity - (int)numericUpDown1.Value < 0)
            {
                MessageBox.Show(@"Данное оборудование отсутствует на складе в нужном количестве", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (!_edit&&_selectedEquipment != null && _selectedEquipment.Availability - (int)numericUpDown1.Value < 0)
            {
                MessageBox.Show(@"Данное оборудование отсутствует на складе в нужном количестве", "", MessageBoxButtons.OK,
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
                    _item.Room_ID = (comboBoxRoom.SelectedItem as Room).Room_ID;
                    _item.Equipment_ID = _selectedEquipment.Equipment_ID;
                    _item.DateOfIssue = DateTime.Now;
                    _item.Quantity = (int)numericUpDown1.Value;

                    _item.Room = null;
                    _item.Equipment = null;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new RoomEquipment()
                    {
                        Room_ID = (comboBoxRoom.SelectedItem as Room).Room_ID,
                        Equipment_ID = _selectedEquipment.Equipment_ID,
                        DateOfIssue = DateTime.Now,
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

     
 


        private void buttonSearchEquipment_Click(object sender, EventArgs e)
        {
            var equipForm = new EquipmentsForm();
            if (equipForm.ShowDialog() == DialogResult.OK)
            {
                _selectedEquipment = equipForm.SelectedEquipment;
                textBoxEquip.Text = _selectedEquipment.ToString();
                labelInventory.Text = _selectedEquipment.InventoryNumber;
                labelAva.Text = _selectedEquipment.Availability.ToString();
                
            }
        }

    


    }
}
