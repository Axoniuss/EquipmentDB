using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;
using EquipmentDB.Properties;

namespace EquipmentDB.Forms.AddEditForms
{
    public partial class AddEditRoomForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private Room _item;

        private readonly bool _edit;
        /// <summary>
        /// Конструктор редактирования
        /// </summary>
        public AddEditRoomForm(Room item)
        {
            _item = item;
            _edit = true;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор добавления
        /// </summary>
        public AddEditRoomForm()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxRoomName.Text))
            {
                MessageBox.Show(@"Не верно заполнено поле " + label1.Text, "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxCorps.SelectedItem == null)
            {
                MessageBox.Show(@"Не выбрано расположения помещения", "", MessageBoxButtons.OK,
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
                    _item.RoomName = textBoxRoomName.Text;
                    _item.Corps_ID = (comboBoxCorps.SelectedItem as Corps).Corps_ID;

                    _item.Corps = null;
                    _repository.UpdateEntity(_item);
                }
                else
                {
                    _item = new Room()
                    {
                        RoomName = textBoxRoomName.Text,
                        Corps_ID = (comboBoxCorps.SelectedItem as Corps).Corps_ID
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
            comboBoxCorps.DataSource = _repository.GetEntityes<Corps>();
            if (_item != null)
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                textBoxRoomName.Text = _item.RoomName;
                comboBoxCorps.SelectedItem = _item.Corps;
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

        private void checkInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxRoomName,
                string.IsNullOrWhiteSpace(textBoxRoomName.Text) ? "Поле не заполнено" : string.Empty);
        }
    }
}
