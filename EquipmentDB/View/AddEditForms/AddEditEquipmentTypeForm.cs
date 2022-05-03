using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditEquipmentTypeForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private EquipmentType _item;

        public EquipmentType EquipmentType { get;private set; }

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditEquipmentTypeForm(EquipmentType item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditEquipmentTypeForm()
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
                    _item.EquipmentTypeName = textBoxPostName.Text;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new EquipmentType()
                    {
                        EquipmentTypeName = textBoxPostName.Text
                    };
                   EquipmentType= _repository.AddEntity(_item);
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
                textBoxPostName.Text = _item.EquipmentTypeName;
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
            errorProvider1.SetError(textBoxPostName,
                string.IsNullOrWhiteSpace(textBoxPostName.Text) ? "Не верно заполнено поле" : string.Empty);
        }
    }
}
