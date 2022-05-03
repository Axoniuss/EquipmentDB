using System;
using System.ComponentModel;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditPostForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private Post _item;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditPostForm(Post item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditPostForm()
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
            return true;
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            if (!Check()) return;
            try
            {
                if (_edit)
                {
                    _item.PostName = textBoxPostName.Text;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new Post()
                    {
                        PostName = textBoxPostName.Text
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
            textBoxPostName.Validating+=TextBoxPostNameOnValidating;
            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                textBoxPostName.Text = _item.PostName;
                buttonAddEdit.Image = Resources.save;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
                buttonAddEdit.Image = Resources.add;
            }
        }

        private void TextBoxPostNameOnValidating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxPostName,
                string.IsNullOrWhiteSpace(textBoxPostName.Text) ? "Поле не заполнено" : string.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
