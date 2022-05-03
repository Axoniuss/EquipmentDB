using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    public partial class EmployeeRoomsForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        /// <summary>
        /// Коллекция для инициализации combobox, в ключая объект с ID=0 - все корпуса
        /// </summary>
        private readonly List<Corps> _corps;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EmployeeRoomsForm()
        {
            _corps = new List<Corps>();
            InitializeComponent();
        }

        #region Приватные методы

        /// <summary>
        /// Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<EmployeeRoom>();
            dataGridView.ClearSelection();
        }


        /// <summary>
        /// Инициализация источника данных для combobox (корпуса)
        /// </summary>
        private void InitComboBox()
        {
            _corps.Add(new Corps() { CorpsName = "Все корпуса" });
            _corps.AddRange(_repository.GetEntityes<Corps>());
            comboBoxCorps.DataSource = _corps;
            comboBoxCorps.SelectedItem = _corps.First();
        }

        #endregion

        #region Обработчики событий
        
        /// <summary>
        /// Обработчика события клика по ячейкам с изображением
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EmployeeRoom;
                new AddEditEmployeeRoomForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EmployeeRoom;
                var result = MessageBox.Show("Удалить запись с ID " + item.EmployeeRoom_ID + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    _repository.RemoveEntity(item, d => d.EmployeeRoom_ID == item.EmployeeRoom_ID);
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
            new AddEditEmployeeRoomForm().ShowDialog();
            UpdateDatagrid();
        }
        
        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void RoomsForm_Load(object sender, EventArgs e)
        {
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
                dataGridView.DataSource = _repository.GetEntityes<EmployeeRoom>(room => room.Room.Corps_ID == corp.Corps_ID);
                dataGridView.ClearSelection();
            }
            else
            {
                UpdateDatagrid();
            }
        }

        #endregion

       

       

    }
}
