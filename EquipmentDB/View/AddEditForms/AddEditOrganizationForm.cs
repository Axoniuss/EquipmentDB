using System;
using System.ComponentModel;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditOrganizationForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private Organization _item;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditOrganizationForm(Organization item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditOrganizationForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxOrganizationName.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label1.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (!maskedTextBoxPhone.MaskFull)
            {
                MessageBox.Show(@"Не верно заполнено поле Контактный телефон", "", MessageBoxButtons.OK,
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
                    _item.OrganizationName = textBoxOrganizationName.Text;
                    _item.ContactPhone = maskedTextBoxPhone.Text;

                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new Organization()
                    {
                        OrganizationName = textBoxOrganizationName.Text,
                        ContactPhone = maskedTextBoxPhone.Text
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
            textBoxOrganizationName.Validating+=textBoxOrganizationNameOnValidating;
            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                textBoxOrganizationName.Text = _item.OrganizationName;
                maskedTextBoxPhone.Text = _item.ContactPhone;
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }

        private void textBoxOrganizationNameOnValidating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxOrganizationName,
                string.IsNullOrWhiteSpace(textBoxOrganizationName.Text) ? "Поле не заполнено" : string.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
