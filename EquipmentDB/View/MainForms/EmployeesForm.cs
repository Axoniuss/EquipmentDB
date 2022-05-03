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
    public partial class EmployeesForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        /// <summary>
        /// Коллекция для инициализации combobox, в ключая объект с ID=0 - все корпуса
        /// </summary>
        private readonly List<Post> _posts;

        private readonly bool _selectMode;

        private bool _sort;

        public Employee SelectedEmployee { get; private set; }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EmployeesForm()
        {
            _posts = new List<Post>();
            InitializeComponent();

        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EmployeesForm(bool selectMode)
        {
            _selectMode = true;
            _posts = new List<Post>();
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
            
            if (e.ColumnIndex == dataGridView.Columns["ReturnColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                
                var result = MessageBox.Show($"Вернуть данные сотрудника с ID {item.Employee_ID} с архива?\n" , "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    item.Post = null;
                    item.Organization = null;
                    item.EquipmentLeasings = null;
                    item.EquipmentLeasings1 = null;
                    item.IsArchive = false;
                    _repository.UpdateEntity(item);
                    // _repository.RemoveEntity(item, d => d.Employee_ID == item.Employee_ID);
                    UpdateDatagrid();
                }
                catch (Exception exception)
                {
                    _repository.HandleException(exception);
                }
            }
            if (e.ColumnIndex == dataGridView.Columns["EquipmentColumn"].Index)
            {
                SelectedEmployee = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                if (SelectedEmployee.EquipmentCount == 0) return;

                Hide();
                new EmployeeEquipmentReportForm(SelectedEmployee).ShowDialog();
                Show();
            }

            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                new AddEditEmployeeForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                if (item.EquipmentCount > 0)
                {
                    MessageBox.Show("Невозможно удалить сотрудника за которым числится выданное оборудование!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show($"Удалить сотрудника с ID {item.Employee_ID}?\nДанная запись будет отмечена как архивная", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    item.Post = null;
                    item.Organization = null;
                    item.EquipmentLeasings = null;
                    item.EquipmentLeasings1 = null;
                    item.IsArchive = true;
                    _repository.UpdateEntity(item);
                    // _repository.RemoveEntity(item, d => d.Employee_ID == item.Employee_ID);
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
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            new AddEditEmployeeForm().ShowDialog();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void Form_Load(object sender, EventArgs e)
        {
            if (_selectMode)
            {
                buttonAdd.Visible = false;
                buttonImportFromFile.Visible = false;
                groupBox1.Location = new Point(12, 6);
                dataGridView.Columns["DeleteColumn"].Visible = false;
                dataGridView.Columns["EditColumn"].Visible = false;
                dataGridView.Columns["EquipmentColumn"].Visible = false;
                checkBoxArchive.Visible = false;
            }
            InitComboBox();
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
            dataGridView.DataSource = _repository.GetEntityes<Employee>(emp => emp.IsArchive == checkBoxArchive.Checked);
            dataGridView.ClearSelection();
        }


        /// <summary>
        /// Инициализация источника данных для combobox (корпуса)
        /// </summary>
        private void InitComboBox()
        {
            _posts.Add(new Post() { PostName = "Все должности" });
            _posts.AddRange(_repository.GetEntityes<Post>());
            comboBoxPosts.DataSource = _posts;
            comboBoxPosts.SelectedItem = _posts.First();
        }

        #endregion

        /// <summary>
        /// Обработка события изменения ввода текста - для текстовых полей поиска
        /// При вводе более 3 букв пытаемся выдать список автодополнения
        /// </summary>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var txBx = sender as TextBox;
            if (txBx != null && txBx.Text.Length < 3) return;

            switch (txBx.Name)
            {
                case "textBoxFName":
                    var autoCompleteFName = new AutoCompleteStringCollection();
                    autoCompleteFName.AddRange(_repository.GetEntityes<Employee>().Select(emp => emp.FName).ToArray());
                    txBx.AutoCompleteCustomSource = autoCompleteFName;
                    break;
                case "textBoxLName":
                    var autoCompleteLName = new AutoCompleteStringCollection();
                    autoCompleteLName.AddRange(_repository.GetEntityes<Employee>().Select(emp => emp.LName).ToArray());
                    txBx.AutoCompleteCustomSource = autoCompleteLName;
                    break;
            }

        }

        /// <summary>
        /// обработка события нажатия кнопки поиска
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var post = comboBoxPosts.SelectedItem as Post;
            dataGridView.DataSource = null;
            dataGridView.DataSource =
                _repository.FindEmployees(textBoxFName.Text, textBoxEmpName.Text, textBoxLName.Text, post);
        }

        /// <summary>
        /// Обработка события нажатия кнопки сброса параметров поиска
        /// </summary>
        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            comboBoxPosts.SelectedItem = _posts.First();
            textBoxFName.Clear();
            textBoxEmpName.Clear();
            textBoxLName.Clear();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события нажатия кнопки импорта сотрудников из файла
        /// </summary>
        private async void buttonImportFromFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            buttonImportFromFile.Enabled = false;
            // асинхронная операция импорта данных сотрудников с файла
            var count = await _repository.ImportEmployeeFromFileAsync(openFileDialog.FileName);

            MessageBox.Show("Импортировано " + count + " сотрудников");

            buttonImportFromFile.Enabled = true;
            UpdateDatagrid();
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            SelectedEmployee = dataGridView.SelectedRows[0].DataBoundItem as Employee;
            if (SelectedEmployee != null)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dataGridView.Columns[e.ColumnIndex];
            var dgList = dataGridView.DataSource as List<Employee>;
            if (dgList == null) return;

            // сортировка при нажатии на столбец даты возврата
            Comparison<Employee> comparison = null;

            // если нажимаем по колонке оранизации
            if (column.Name == "Organization")
            {
                if (_sort)
                {
                    comparison = ((x, y) => Compare(x.Organization, y.Organization));
                }
                else
                {
                    comparison = ((x, y) => Compare(y.Organization, x.Organization));
                }
                _sort = !_sort;

            }
            if (comparison == null) return;

            dgList.Sort(comparison);
            dataGridView.DataSource = null;
            dataGridView.DataSource = dgList;
            dataGridView.ClearSelection();
        }

        private static int Compare(Organization x, Organization y)
        {

            if (x == null && y != null)
            {
                return -1;
            }
            if (y == null && x != null)
            {
                return 1;
            }
            if (x == null && y == null)
            {
                return 0;
            }
            return string.Compare(x.OrganizationName, y.OrganizationName, StringComparison.InvariantCulture);

        }

        private void checkBoxArchive_CheckedChanged(object sender, EventArgs e)
        {
            buttonAdd.Visible = !checkBoxArchive.Checked;
            buttonImportFromFile.Visible = !checkBoxArchive.Checked;
            dataGridView.Columns["ArchiveColumn"].Visible = checkBoxArchive.Checked;
            dataGridView.Columns["EditColumn"].Visible = !checkBoxArchive.Checked;
            dataGridView.Columns["DeleteColumn"].Visible = !checkBoxArchive.Checked;
            dataGridView.Columns["ReturnColumn"].Visible = checkBoxArchive.Checked;
            UpdateDatagrid();

        }
    }
}
