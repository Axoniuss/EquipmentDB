using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditManufacturerForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private Manufacturer _item;

        public Manufacturer Manufacturer { get;private set; }

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditManufacturerForm(Manufacturer item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditManufacturerForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxManufacturer.Text))
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
                    _item.ManufacturerName = textBoxManufacturer.Text;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new Manufacturer()
                    {
                        ManufacturerName = textBoxManufacturer.Text
                    };
                  Manufacturer= _repository.AddEntity(_item);
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
                textBoxManufacturer.Text = _item.ManufacturerName;
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
            errorProvider1.SetError(textBoxManufacturer,
                string.IsNullOrWhiteSpace(textBoxManufacturer.Text) ? "Не верно заполнено поле" : string.Empty);
        }
    }
}
