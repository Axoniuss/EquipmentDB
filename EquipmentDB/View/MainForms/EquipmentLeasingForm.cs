
using EquipmentDB.Forms.AddEditForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Model;


namespace EquipmentDB.Forms.MainForms
{
    public partial class EquipmentLeasingForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        /// <summary>
        /// Поле используется при переходе с окна Всё оборудование
        /// </summary>
        private Equipment _equipment;

        private List<Employee> _employees;
        private List<Employee> _employees1;

        private bool _sort;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EquipmentLeasingForm(Equipment equipment)
        {
            _equipment = equipment;
            InitializeComponent();
        }


        /// <summary>
        /// Конструктор формы - перегрузка
        /// </summary>
        public EquipmentLeasingForm() : this(null) { }

        #region Обработчики событий

        /// <summary>
        /// Обработчика события клика по ячейкам с изображением
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView.Columns["EquipmentColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EquipmentLeasing;
                new EmployeeEquipmentForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EquipmentLeasing;
                new AddEditEquipmentLeasingForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as EquipmentLeasing;
                var result = MessageBox.Show("Удалить запись с ID " + item.EquipmentLeasing_ID + " и вернуть выданное оборудование на склад?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    item.Employee = null;
                    item.Employee1 = null;
                    item.EmployeeEquipments = null;
                    item.IsArchive = true;
                    _repository.UpdateEntity(item);
                    //_repository.RemoveEntity(item, d => d.EquipmentLeasing_ID == item.EquipmentLeasing_ID);
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
            var eqLeasing = new AddEditEquipmentLeasingForm();
            if (eqLeasing.ShowDialog() == DialogResult.OK)
            {
                new EmployeeEquipmentForm(eqLeasing.EquipmentLeasing).ShowDialog();
                UpdateDatagrid();
            }
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
            if (_equipment != null)
            {
                dataGridView.DataSource = _repository.GetEntityes<EquipmentLeasing>(el => el.EmployeeEquipments.Any
                                                                                              (eq => eq.Equipment_ID == _equipment.Equipment_ID) && el.IsArchive == checkBoxArchive.Checked);
                _equipment = null;
            }
            else
            {
                dataGridView.DataSource = _repository.GetEntityes<EquipmentLeasing>(leasing => leasing.IsArchive == checkBoxArchive.Checked);
            }
            dateTimePickerEnter.Checked = false;
            dateTimePickerReturn.Checked = false;
            comboBoxEmployeeOut.SelectedItem = _employees.First();
            comboBoxEmployeeIn.SelectedItem = _employees1.First();
            dataGridView.ClearSelection();
            textBoxInventoryNumber.Clear();
        }


        /// <summary>
        /// Инициализация источника данных для combobox (корпуса)
        /// </summary>
        private void InitComboBox()
        {
            // ------------------------------------------------

            _employees = new List<Employee>() { new Employee() };
            _employees.AddRange(_repository.GetEntityes<Employee>());
            comboBoxEmployeeOut.DataSource = _employees;
            comboBoxEmployeeOut.SelectedItem = _employees.First();

            _employees1 = new List<Employee>() { new Employee() };
            _employees1.AddRange(_repository.GetEntityes<Employee>());
            comboBoxEmployeeIn.DataSource = _employees1;
            comboBoxEmployeeIn.SelectedItem = _employees1.First();
        }

        #endregion

        /// <summary>
        /// Обработка события нажатия кнопки поиска
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var empOut = comboBoxEmployeeOut.SelectedItem as Employee;
            var empIn = comboBoxEmployeeIn.SelectedItem as Employee;
            var dtOut = dateTimePickerEnter.Checked ? dateTimePickerEnter.Value.Date : (DateTime?)null;
            var dtReturn = dateTimePickerReturn.Checked ? dateTimePickerReturn.Value.Date : (DateTime?)null;
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.FindEquipmentLeasings(empOut, empIn, dtOut, dtReturn, textBoxInventoryNumber.Text, checkBoxArchive.Checked);
        }


        /// <summary>
        /// Обработка события нажатия на шапку столбца таблицы
        /// </summary>
        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dataGridView.Columns[e.ColumnIndex];
            var dgList = dataGridView.DataSource as List<EquipmentLeasing>;
            if (dgList == null) return;

            // сортировка при нажатии на столбец даты возврата
            Comparison<EquipmentLeasing> comparison = null;
            if (column.Name == "dateReturnColumn")
            {
                comparison = _sort
                    ? ((x, y) => x.DateReturn.CompareTo(y.DateReturn))
                    : new Comparison<EquipmentLeasing>((x, y) => y.DateReturn.CompareTo(x.DateReturn));
                _sort = !_sort;
            }
            if (comparison == null) return;

            dgList.Sort(comparison);
            dataGridView.DataSource = null;
            dataGridView.DataSource = dgList;
            dataGridView.ClearSelection();
        }


        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGridView.Rows[e.RowIndex];
            var data = row.DataBoundItem as EquipmentLeasing;
            if (data == null) return;
            if (!data.IsArchive && data.DateReturn.Date < DateTime.Now.Date)
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void checkBoxArchive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
            buttonAddStatus.Visible = !checkBoxArchive.Checked;
            dataGridView.Columns["ArchiveColumn"].Visible = checkBoxArchive.Checked;
            dataGridView.Columns["EditColumn"].Visible = !checkBoxArchive.Checked;
            //dataGridView.Columns["DeleteColumn"].Visible = !checkBoxArchive.Checked;
        }
    }
}
