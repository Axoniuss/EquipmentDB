using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditEmployeeForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private Employee _item;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditEmployeeForm(Employee item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditEmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверки заполнения полей
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxFName.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label1.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label2.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxLName.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label3.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (maskedTextBoxPhone.Text.Trim(maskedTextBoxPhone.Mask.ToCharArray()).Length > 0 && !maskedTextBoxPhone.MaskFull)
            {
                MessageBox.Show(@"Телефон должен быть введён полностью или отсутствовать", "", MessageBoxButtons.OK,
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
                string phone = null;
                if (maskedTextBoxPhone.Text.Trim(maskedTextBoxPhone.Mask.ToCharArray()).Length != 0)
                {
                    phone = maskedTextBoxPhone.Text;
                }
                var organizationId = (comboBoxOrganization.SelectedItem as Organization).Organization_ID;
                if (_edit)
                {
                    _item.FName = textBoxFName.Text;
                    _item.EmpName = textBoxName.Text;
                    _item.LName = textBoxLName.Text;
                    _item.Phone = phone;
                    _item.Post_ID = (comboBoxPosts.SelectedItem as Post).Post_ID;
                    _item.Organization_ID = organizationId == 0 ? (int?)null : organizationId;
                    
                    _item.Post = null;
                    _item.Organization = null;
                    _item.EquipmentLeasings = null;
                    _item.EquipmentLeasings1 = null;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new Employee()
                    {
                        FName = textBoxFName.Text,
                        EmpName = textBoxName.Text,
                        LName = textBoxLName.Text,
                        Phone = phone,
                        Post_ID = (comboBoxPosts.SelectedItem as Post).Post_ID,
                        Organization_ID = organizationId == 0 ? (int?)null : organizationId,
                        IsArchive = false
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
            comboBoxPosts.DataSource = _repository.GetEntityes<Post>();
            var organizations = new List<Organization>() { new Organization() { OrganizationName = "Осутствует" } };
            organizations.AddRange(_repository.GetEntityes<Organization>());
            comboBoxOrganization.DataSource = organizations;

            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";

                textBoxFName.Text = _item.FName;
                textBoxName.Text = _item.EmpName;
                textBoxLName.Text = _item.LName;
                maskedTextBoxPhone.Text = _item.Phone;
                comboBoxPosts.SelectedItem = _item.Post;

                if (_item.Organization != null)
                {
                    comboBoxOrganization.SelectedItem = _item.Organization;
                }
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }

        private void textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var error = "Не верно заполнено поле";
            errorProvider1.SetError(textBoxFName, string.IsNullOrWhiteSpace(textBoxFName.Text) ? error : string.Empty);
            errorProvider2.SetError(textBoxName, string.IsNullOrWhiteSpace(textBoxName.Text) ? error : string.Empty);
            errorProvider3.SetError(textBoxLName, string.IsNullOrWhiteSpace(textBoxLName.Text) ? error : string.Empty);

            if (maskedTextBoxPhone.Text.Trim(maskedTextBoxPhone.Mask.ToCharArray()).Length > 0 && !maskedTextBoxPhone.MaskFull)
            {
                errorProvider4.SetError(maskedTextBoxPhone, "Телефон должен быть введён полностью или отсутствовать");
            }
            else
            {
                errorProvider4.SetError(maskedTextBoxPhone, string.Empty);
            }
        }
    }
}
