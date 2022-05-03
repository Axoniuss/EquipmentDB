using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.MainForms;
using EquipmentDB.Model;

using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditEmployeeRoomForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private EmployeeRoom _item;

        private Employee _selectedEmployee;
        private Room _selectedRoom;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditEmployeeRoomForm(EmployeeRoom item)
        {
            _item = item;
            _edit = true;
            _selectedEmployee = _item.Employee;
            _selectedRoom = _item.Room;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditEmployeeRoomForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (_selectedEmployee == null)
            {
                MessageBox.Show(@"Не выбран сотрудник", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (_selectedRoom == null)
            {
                MessageBox.Show(@"Не выбрано помещение", "", MessageBoxButtons.OK,
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
                    _item.Employee_ID = _selectedEmployee.Employee_ID;
                    _item.Room_ID = _selectedRoom.Room_ID;
                    _item.Date=DateTime.Now.Date;

                    _item.Employee = null;
                    _item.Room = null;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new EmployeeRoom
                    {
                        Employee_ID = _selectedEmployee.Employee_ID,
                        Room_ID = _selectedRoom.Room_ID,
                        Date = DateTime.Now.Date
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
                textBoxEmployee.Text = _item.Employee.ToString();
                textBoxRoom.Text = _item.Room.ToString();
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
            errorProvider1.SetError(textBoxEmployee,
                _selectedEmployee == null ? "Сотрудник не выбран" : string.Empty);

            errorProvider2.SetError(textBoxRoom,
                _selectedRoom == null ? "Помещение не выбрано" : string.Empty);
        }

        /// <summary>
        /// Обработкас события нажатия кнопки поиска помещения
        /// </summary>
        private void buttonSearchRoom_Click(object sender, EventArgs e)
        {
            var roomForm = new RoomsForm(true);
            if (roomForm.ShowDialog()==DialogResult.OK)
            {
                _selectedRoom = roomForm.SelectedRoom;
                textBoxRoom.Text = _selectedRoom.ToString();
            }
        }

        /// <summary>
        /// Обработкас события нажатия кнопки поиска сотрудника
        /// </summary>
        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeesForm(true);
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                _selectedEmployee = employeeForm.SelectedEmployee;
                textBoxEmployee.Text = _selectedEmployee.ToString();
            }
        }

    }
}
