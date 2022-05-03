using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.TemplateFiller;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    public partial class EmployeeEquipmentForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        private EquipmentLeasing _equipmentLeasing;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EmployeeEquipmentForm(EquipmentLeasing equipmentLeasing)
        {
            _equipmentLeasing = equipmentLeasing;
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
            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EmployeeEquipment;
                new AddEditEmployeeEquipmentForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EmployeeEquipment;
                var result = MessageBox.Show("Удалить запись с ID " + item.EmployeeEquipment_ID + " и вернуть оборудование на склад?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    _repository.RemoveEntity(item, d => d.EmployeeEquipment_ID == item.EmployeeEquipment_ID);
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddEditEmployeeEquipmentForm(_equipmentLeasing).ShowDialog();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void RoomsForm_Load(object sender, EventArgs e)
        {
            _equipmentLeasing = _repository.GetEntityes<EquipmentLeasing>(leasing =>
                leasing.EquipmentLeasing_ID == _equipmentLeasing.EquipmentLeasing_ID).First();

            buttonAdd.Visible = !_equipmentLeasing.IsArchive;
            dataGridView.Columns["EditColumn"].Visible= !_equipmentLeasing.IsArchive;
            dataGridView.Columns["DeleteColumn"].Visible = !_equipmentLeasing.IsArchive;

            labelCurrentEmp.Text = _equipmentLeasing.Employee.ToString();
            labelInEmp.Text = _equipmentLeasing.Employee1.ToString();
            labelDateIssue.Text = _equipmentLeasing.DateOfIssue.ToShortDateString();
            labelDateReturn.Text = _equipmentLeasing.DateReturn.ToShortDateString();
            UpdateDatagrid();
        }

        #endregion

        #region Приватные методы

        /// <summary>
        /// Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<EmployeeEquipment>(empEq => empEq.EquipmentLeasing_ID == _equipmentLeasing.EquipmentLeasing_ID);
            dataGridView.ClearSelection();
            _equipmentLeasing = _repository.GetEntityes<EquipmentLeasing>(leasing =>
                leasing.EquipmentLeasing_ID == _equipmentLeasing.EquipmentLeasing_ID).First();
        }



        #endregion

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog()
            {
                Filter = "MS Word files (*.docx)|*.docx",
                FileName = "Акт приема передачи.docx"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;
            try
            {
                using (var template = new EmployeeEquipmentTemplate(_equipmentLeasing))
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



    }
}
