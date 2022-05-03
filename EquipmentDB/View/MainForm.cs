using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.MainForms;
using EquipmentDB.Forms.ReferenceForms;
using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;
using EquipmentDB.Model.Verfication;

namespace EquipmentDB.Forms
{
    public partial class MainForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        /// <summary>
        /// Коллекция для инициализации combobox
        /// </summary>
        private List<Manufacturer> _manufacturers;
        private List<EquipmentType> _equipmentTypes;
        private List<BalanceType> _balanceTypes;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Menu items

        private void oрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new OrganizationsForm().ShowDialog();
            Show();
        }
        private void должностьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new PostsForm().ShowDialog();
            Show();
        }

        private void типОборудованияToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new EquipmentTypesForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void фирмыToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new ManufacturersForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void вводВЭксплуатациюToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new RoomEquipmentForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void всеПомещенияToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new RoomsForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void корпусаToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Hide();
            new CorpsForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new UsersForm().ShowDialog();
            Show();
        }

        private void временноеИспользованиеToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new EquipmentLeasingForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void ответсвенныеСотрудникиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
        }

        private void списанноеОборудованиеToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new WriteOffEquipmentsForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        #endregion

        /// <summary>
        /// обработка события загрузки главной формы
        /// </summary>
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (_repository.FirstStart())
            {
                Hide();
                MessageBox.Show(" Первый запуск программы. \n\nНеобходимо добавить пользователя системы в следующем порядке:" +
                                "\n1. Добавить должность сотрудника" +
                                "\n2. Добавить сотрудника, который будет привязан к пользователю" +
                                "\n3. Добавить нового пользователя системы", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new AddEditPostForm().ShowDialog();
                new AddEditEmployeeForm().ShowDialog();
                new AddEditUserForm().ShowDialog();
                Close();
            }
            toolStripStatusLabel1.Text = "   Пользователь: " + _repository.GetCurrentUser()?.Employee;
            InitComboBox();
            UpdateDatagrid();
        }

        /// <summary>
        /// метод обноваления данных в таблице
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<Equipment>();
            dataGridView.ClearSelection();

            comboBoxManufacturers.SelectedItem = _manufacturers.First();
            comboBoxBalanceType.SelectedItem = _balanceTypes.First();
            comboBoxEquipType.SelectedItem = _equipmentTypes.First();

            textBoxSerialNumber.Clear();
            textBoxEquipmentName.Clear();
            textBoxInventoryNumber.Clear();
        }

        /// <summary>
        /// Инициализация источника данных для combobox (корпуса)
        /// </summary>
        private void InitComboBox()
        {
            _manufacturers = new List<Manufacturer>();
            _equipmentTypes = new List<EquipmentType>();
            _balanceTypes = new List<BalanceType>();
            // ------------------------------------------------
            _manufacturers.Add(new Manufacturer() { ManufacturerName = "Все производители" });
            _manufacturers.AddRange(_repository.GetEntityes<Manufacturer>());
            comboBoxManufacturers.DataSource = _manufacturers;
            comboBoxManufacturers.SelectedItem = _manufacturers.First();
            // ------------------------------------------------
            _equipmentTypes.Add(new EquipmentType() { EquipmentTypeName = "Все типы оборудования" });
            _equipmentTypes.AddRange(_repository.GetEntityes<EquipmentType>());
            comboBoxEquipType.DataSource = _equipmentTypes;
            comboBoxEquipType.SelectedItem = _equipmentTypes.First();
            // ------------------------------------------------
            _balanceTypes.Add(new BalanceType() { BalanceTypeName = "Все типы учёта" });
            _balanceTypes.AddRange(_repository.GetEntityes<BalanceType>());
            comboBoxBalanceType.DataSource = _balanceTypes;
            comboBoxBalanceType.SelectedItem = _balanceTypes.First();
        }

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
                case "textBoxSerialNumber":
                    var autoCompleteFName = new AutoCompleteStringCollection();
                    autoCompleteFName.AddRange(_repository.GetEntityes<Equipment>().
                        Where(eq => eq.Serial != null && eq.Serial.Contains(txBx.Text)).Select(eq => eq.Serial).ToArray());
                    txBx.AutoCompleteCustomSource = autoCompleteFName;
                    break;
                case "textBoxEquipmentName":
                    var autoCompleteEquipmentName = new AutoCompleteStringCollection();
                    autoCompleteEquipmentName.AddRange(_repository.GetEntityes<Equipment>().Where(eq => eq.EquipmentName.ToLower().Contains(txBx.Text.ToLower())).
                        Select(eq => eq.EquipmentName).ToArray());
                    txBx.AutoCompleteCustomSource = autoCompleteEquipmentName;
                    break;
                case "textBoxInventoryNumber":
                    var autoCompleteLName = new AutoCompleteStringCollection();
                    autoCompleteLName.AddRange(_repository.GetEntityes<Equipment>().Where(eq => eq.InventoryNumber.Contains(txBx.Text)).
                        Select(eq => eq.InventoryNumber).ToArray());
                    txBx.AutoCompleteCustomSource = autoCompleteLName;
                    break;
            }

        }

        /// <summary>
        /// обработка события нажатия кнопки поиска
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var manufacturer = comboBoxManufacturers.SelectedItem as Manufacturer;
            var eqType = comboBoxEquipType.SelectedItem as EquipmentType;
            var balanceType = comboBoxBalanceType.SelectedItem as BalanceType;

            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.FindEquipments(manufacturer, eqType, balanceType,
                textBoxSerialNumber.Text, textBoxInventoryNumber.Text, textBoxEquipmentName.Text);
        }

        /// <summary>
        /// Обработка события нажатия кнопки сброса параметров поиска
        /// </summary>
        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события нажатия кнопки добавления оборудования
        /// </summary>
        private void buttonAddEquip_Click(object sender, System.EventArgs e)
        {
            new AddEditEquipmentForm().ShowDialog();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработчика события клика по ячейкам с изображением
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
            //    return;
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            // списать обрудование
            if (e.ColumnIndex == dataGridView.Columns["WriteOffColumn"].Index)
            {
                var selectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
                new AddEditWriteOffEquipmentForm(selectedEquipment).ShowDialog();
                UpdateDatagrid();
            }
            // показать оборудование в окне списанного
            if (e.ColumnIndex == dataGridView.Columns["WriteOffShowColumn"].Index)
            {
                Hide();
                var selectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
                new WriteOffEquipmentsForm(selectedEquipment).ShowDialog();
                Show();
                UpdateDatagrid();
            }
            // показать оборудование в окне временного использования оборудования
            if (e.ColumnIndex == dataGridView.Columns["EquipmentLeasingColumn"].Index)
            {
                Hide();
                var selectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
                new EquipmentLeasingForm(selectedEquipment).ShowDialog();
                Show();
                UpdateDatagrid();
            }
            // показать оборудование в окне оборудование в помещениях
            if (e.ColumnIndex == dataGridView.Columns["RoomEquipmentColumn"].Index)
            {
                Hide();
                var selectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
                new RoomEquipmentForm(selectedEquipment).ShowDialog();
                Show();
                UpdateDatagrid();
            }

            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
                new AddEditEquipmentForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
                if (!item.CanDelete)
                {
                    MessageBox.Show("Удаление невозможно.\nДля удаления оборудования необходимо вернуть его на склад с помещений и временного использования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Удалить оборудование с ID " + item.Equipment_ID + " со склада?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    _repository.RemoveEntity(item, d => d.Equipment_ID == item.Equipment_ID);
                    UpdateDatagrid();
                }
                catch (Exception exception)
                {
                    _repository.HandleException(exception);
                }
            }
        }

        #region Обработчики событий кнопок левой части окна

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new RoomEquipmentForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new EquipmentLeasingForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new WriteOffEquipmentsForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        #endregion

        private void сверкаОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = new EquipmentVerificator().
                        LoadFromExcelFile(openFile.FileName, 4).
                        LoadEquipmentFromRepository(_repository, 1).
                        Verificate();

                    new VerificationEquipmentForm(data).ShowDialog();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void пользователиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new UsersForm().ShowDialog();
            Show();
        }

        private void резервированиеБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _repository.CreateBackup(dlg.SelectedPath);
                    MessageBox.Show(" Резервный файл БД успешно создан", "Резервирование БД", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    _repository.HandleException(exception);
                    MessageBox.Show(
                        "Рекомендуется сохранять резервные копии на сьёмный носитель и не использовать системный диск",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            Application.EnableVisualStyles();
            new EmployeesForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void ответсвенныеСотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new EmployeeRoomsForm().ShowDialog();
            UpdateDatagrid();
            Show();
        }

        private void восстановитьФайлыБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog {Filter = "backup files (*.bak)|*.bak"};
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _repository.RestoreDatabase(openFile.FileName);
                    MessageBox.Show($"Базы данных успешно восстановлена", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UpdateDatagrid();
                }
                catch (Exception exception)
                {
                    _repository.HandleException(exception);
                }

            }
        }

       

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Help\\Operator Manual.pdf"))
            {
                Process.Start("Help\\Operator Manual.pdf");
            }
            else
            {
                MessageBox.Show("Файл со справкой не найден !", "Внимание", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new AboutForm().ShowDialog();
            Show();
        }
    }
}
