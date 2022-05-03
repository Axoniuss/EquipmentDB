using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.MainForms;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditEquipmentLeasingForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        public EquipmentLeasing EquipmentLeasing { get; private set; }

        private Employee _selectedEmployee;

        private readonly bool _edit;

        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditEquipmentLeasingForm(EquipmentLeasing equipmentLeasing)
        {
            EquipmentLeasing = equipmentLeasing;
            _edit = true;
            _selectedEmployee = equipmentLeasing.Employee1;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditEquipmentLeasingForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (_selectedEmployee == null)
            {
                MessageBox.Show(@"Не выбран сотрудник принимающий оборудование", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (dateTimePickerReturn.Value.Date < dateTimePickerIssue.Value.Date)
            {
                MessageBox.Show(@"Дата возврата оборудования не может быть раньше даты выдачи", "", MessageBoxButtons.OK,
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
                    EquipmentLeasing.EmployeeOut_ID = _repository.GetCurrentUser().User_ID;
                    EquipmentLeasing.EmployeeIn_ID = _selectedEmployee.Employee_ID;
                    EquipmentLeasing.DateOfIssue = dateTimePickerIssue.Value.Date;
                    EquipmentLeasing.DateReturn = dateTimePickerReturn.Value.Date;

                    EquipmentLeasing.Employee = null;
                    EquipmentLeasing.Employee1 = null;
                    EquipmentLeasing.EmployeeEquipments = null;
                    _repository.UpdateEntity(EquipmentLeasing);
                }
                else
                {
                    EquipmentLeasing = new EquipmentLeasing()
                    {
                        EmployeeOut_ID = _repository.GetCurrentUser().Employee_ID,
                        EmployeeIn_ID = _selectedEmployee.Employee_ID,
                        DateOfIssue = dateTimePickerIssue.Value.Date,
                        DateReturn = dateTimePickerReturn.Value.Date,
                    };
                    EquipmentLeasing = _repository.AddEntity(EquipmentLeasing);
                    DialogResult = DialogResult.OK;
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
            textBoxCurrentEmployee.Text = _repository.GetCurrentUser().Employee.ToString();

            if (_edit)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                dateTimePickerIssue.Value = EquipmentLeasing.DateOfIssue;
                dateTimePickerReturn.Value = EquipmentLeasing.DateReturn;
                textBoxEmployeeIn.Text = _selectedEmployee.ToString();
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Далее";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки поиска сотрудника
        /// </summary>
        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            var empForm = new EmployeesForm(true);
            if (empForm.ShowDialog() == DialogResult.OK)
            {
                _selectedEmployee = empForm.SelectedEmployee;
                textBoxEmployeeIn.Text = _selectedEmployee.ToString();
            }
        }


    }
}
