using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;


namespace EquipmentDB.Forms.MainForms
{
    public partial class RoomsForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        public Room SelectedRoom { get; private set; }
        /// <summary>
        /// Коллекция для инициализации combobox, в ключая объект с ID=0 - все корпуса
        /// </summary>
        private readonly List<Corps> _corps;

        private readonly bool _selectMode;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public RoomsForm()
        {
            _corps = new List<Corps>();
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public RoomsForm(bool selectMode)
        {
            _selectMode = true;
            _corps = new List<Corps>();
            InitializeComponent();
        }

        #region Обработчики событий

        /// <summary>
        /// Обработчика события клика по ячейкам с изображением
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView.Columns["PassportColumn"].Index)
            {
                SelectedRoom = dataGridView.SelectedRows[0].DataBoundItem as Room;
                new RoomPassportForm(SelectedRoom).ShowDialog();
            }
            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Room;
                new AddEditRoomForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Room;
                var result = MessageBox.Show("Удалить помещение с ID " + item.Room_ID + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    _repository.RemoveEntity(item, d => d.Room_ID == item.Room_ID);
                    UpdateDatagrid();
                }
                catch (Exception exception)
                {
                    _repository.HandleException(exception);
                }
            }
        }

        /// <summary>
        /// Обработчик события добавления нового объекта
        /// </summary>
        private void buttonAddStatus_Click_1(object sender, EventArgs e)
        {
            new AddEditRoomForm().ShowDialog();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void RoomsForm_Load(object sender, EventArgs e)
        {
            if (_selectMode)
            {
                buttonAdd.Visible = false;
                dataGridView.Columns["EditColumn"].Visible = false;
                dataGridView.Columns["DeleteColumn"].Visible = false;
                //dataGridView.Columns["PassportColumn"].Visible = false;
                //dataGridView.Columns["SelectColumn"].Visible = true;
                groupBox1.Location = new Point(12, 6);
            }
            InitComboBox();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события нажатия кнопки сброса фильтра
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxCorps.SelectedItem = _corps.First();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события изменения выбора в combobox (корпуса)
        /// </summary>
        private void comboBoxCorps_SelectedValueChanged(object sender, EventArgs e)
        {
            var corp = comboBoxCorps.SelectedItem as Corps;
            if (corp != null && corp.Corps_ID != 0)
            {
                dataGridView.DataSource = null;
                dataGridView.DataSource = _repository.GetEntityes<Room>(room => room.Corps_ID == corp.Corps_ID);
            }
            else
            {
                UpdateDatagrid();
            }
        }

        #endregion

        #region Приватные методы

        /// <summary>
        /// Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<Room>();
            dataGridView.ClearSelection();
        }


        /// <summary>
        /// Инициализация источника данных для combobox (корпуса)
        /// </summary>
        private void InitComboBox()
        {

            _corps.AddRange(_repository.GetEntityes<Corps>());
            comboBoxCorps.DataSource = _corps;
            comboBoxCorps.SelectedItem = _corps.First();
        }

        #endregion

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            SelectedRoom = dataGridView.SelectedRows[0].DataBoundItem as Room;
            if (SelectedRoom != null) DialogResult = DialogResult.OK;
        }

        private void comboBoxCorps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
