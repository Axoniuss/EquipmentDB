using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;

using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditCorpsForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private Corps _item;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditCorpsForm(Corps item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditCorpsForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxPostName.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label1.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxAdress.Text))
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
                if (_edit)
                {
                    _item.CorpsName = textBoxPostName.Text;
                    _item.Adress = textBoxAdress.Text;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new Corps()
                    {
                        CorpsName = textBoxPostName.Text,
                        Adress = textBoxAdress.Text
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
                textBoxPostName.Text = _item.CorpsName;
                textBoxAdress.Text = _item.Adress;
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxPostName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxPostName,string.IsNullOrWhiteSpace(textBoxPostName.Text) ? "Не верно заполнено поле " : string.Empty);
            errorProvider2.SetError(textBoxAdress, string.IsNullOrWhiteSpace(textBoxAdress.Text) ? "Не верно заполнено поле " : string.Empty);
        }
    }
}
