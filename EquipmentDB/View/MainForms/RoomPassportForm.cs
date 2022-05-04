using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.TemplateFiller;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    public partial class RoomPassportForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        public Room Room { get; private set; }


        /// <summary>
        /// Конструктор формы
        /// </summary>
        public RoomPassportForm(Room room)
        {
            Room = room;
            InitializeComponent();
        }

        #region Обработчики событий

        /// <summary>
        /// Обработчика события клика по ячейкам с изображением
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dataGridViewEquipments.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridViewEquipments.Columns["EditColumn"].Index)
            {
                var item = dataGridViewEquipments.SelectedRows[0].DataBoundItem as Room;
                new AddEditRoomForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridViewEquipments.Columns["DeleteColumn"].Index)
            {
                var item = dataGridViewEquipments.SelectedRows[0].DataBoundItem as Room;
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
            UpdateDatagrid();
        }


        #endregion

        #region Приватные методы

        /// <summary>
        /// Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridViewEquipments.DataSource = null;
            dataGridViewEquipments.DataSource = _repository.GetEntityes<RoomEquipment>(req => req.Room_ID == Room.Room_ID);
            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = _repository.GetEntityes<EmployeeRoom>(er => er.Room_ID == Room.Room_ID);
            dataGridViewEquipments.ClearSelection();
            dataGridViewEmployees.ClearSelection();
        }

        #endregion

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //var report=  new ReportForm("RoomPassport"){Room = Room};
            //report.ShowDialog();
            var saveFile = new SaveFileDialog()
            {
                Filter = "MS Word files (*.docx)|*.docx",
                FileName = "Паспорт помещения " + Room.RoomName
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;


            try
            {
                using (var template = new RoomPassportTemplate(Room))
                {
                    WordTemplateFiller.CreateWordDocument(template, saveFile.FileName);
                }
                var result = MessageBox.Show("Документ успешно создан. Открыть его для просмотра?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process.Start(saveFile.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void dataGridViewEquipments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
