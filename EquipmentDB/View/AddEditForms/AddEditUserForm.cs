using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditUserForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private User _item;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditUserForm(User item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditUserForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label1.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label2.Text, "", MessageBoxButtons.OK,
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
                var employee = comboBoxEmplyee.SelectedItem as Employee;
                if (_edit)
                {
                    _item.Login = textBoxLogin.Text;
                    _item.Password = textBoxPassword.Text;
                    _item.Employee_ID = (comboBoxEmplyee.SelectedItem as Employee).Employee_ID;


                    _item.Employee = null;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new User()
                    {
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        Employee_ID = (comboBoxEmplyee.SelectedItem as Employee).Employee_ID
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

            comboBoxEmplyee.DataSource = _repository.GetEntityes<Employee>();
            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                textBoxLogin.Text = _item.Login;
                textBoxPassword.Text = _item.Password;
                comboBoxEmplyee.SelectedItem = _item.Employee;
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }

        private void textBoxPostName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxLogin,
                string.IsNullOrWhiteSpace(textBoxLogin.Text) ? "Поле не заполнено" : string.Empty);
            errorProvider2.SetError(textBoxPassword,
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ? "Поле не заполнено" : string.Empty);
        }


    }
}
