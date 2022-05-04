using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;


namespace EquipmentDB.Forms.MainForms
{
    public partial class EquipmentsForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        /// <summary>
        /// Коллекция для инициализации combobox
        /// </summary>
        private List<Manufacturer> _manufacturers;
        private List<EquipmentType> _equipmentTypes;


        

        public Equipment SelectedEquipment { get; private set; }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EquipmentsForm()
        {
            InitializeComponent();
            InitComboBox();
        }

        
        #region Обработчики событий

        /// <summary>
        /// Обработчика события клика по ячейкам с изображением
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
            //    return;

            // списать обрудование
            //if (e.ColumnIndex == dataGridView.Columns["WriteOffColumn"].Index)
            //{
            //    SelectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
            //    new AddEditWriteOffEquipmentForm(SelectedEquipment).ShowDialog();
            //    UpdateDatagrid();
            //}
            //// показать оборудование в окне списанного
            //if (e.ColumnIndex == dataGridView.Columns["WriteOffShowColumn"].Index)
            //{
            //    SelectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
            //    new WriteOffEquipmentsForm(SelectedEquipment).ShowDialog();
            //}
            //// показать оборудование в окне временного использования оборудования
            //if (e.ColumnIndex == dataGridView.Columns["EquipmentLeasingColumn"].Index)
            //{
            //    SelectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
            //    new EquipmentLeasingForm(SelectedEquipment).ShowDialog();
            //}
            //// показать оборудование в окне оборудование в помещениях
            //if (e.ColumnIndex == dataGridView.Columns["RoomEquipmentColumn"].Index)
            //{
            //    SelectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
            //    new RoomEquipmentForm(SelectedEquipment).ShowDialog();
            //}

            //if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            //{
            //    var item = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
            //    new AddEditEquipmentForm(item).ShowDialog();
            //    UpdateDatagrid();
            //}
            //if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            //{
            //    var item = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
            //    var result = MessageBox.Show("Удалить оборудование с ID " + item.Equipment_ID + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //    if (result != DialogResult.OK) return;

            //    try
            //    {
            //        _repository.RemoveEntity(item, d => d.Equipment_ID == item.Equipment_ID);
            //        UpdateDatagrid();
            //    }
            //    catch (Exception exception)
            //    {
            //        _repository.HandleException(exception);
            //    }
            //}
        }

        /// <summary>
        /// Обработчик события добавления нового объекта
        /// </summary>
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            new AddEditEquipmentForm().ShowDialog();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void Form_Load(object sender, EventArgs e)
        {
            //if (_selectMode)
            //{
            //    dataGridView.Columns["EditColumn"].Visible = false;
            //    dataGridView.Columns["DeleteColumn"].Visible = false;
            //    //dataGridView.Columns["SelectColumn"].Visible = true;
            //    dataGridView.Columns["RoomEquipmentColumn"].Visible = false;
            //    dataGridView.Columns["EquipmentLeasingColumn"].Visible = false;
            //    dataGridView.Columns["WriteOffShowColumn"].Visible = false;
            //    dataGridView.Columns["WriteOffColumn"].Visible = false;
                
            //    groupBox1.Location = new Point(12, 6);
            //}
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
            dataGridView.DataSource = _repository.GetEntityes<Equipment>();
            dataGridView.ClearSelection();
            comboBoxManufacturers.SelectedItem = _manufacturers.First();
            comboBoxEquipType.SelectedItem = _equipmentTypes.First();

            textBoxSerialNumber.Clear();
            textBoxInventoryNumber.Clear();
        }


        /// <summary>
        /// Инициализация источника данных для combobox (корпуса)
        /// </summary>
        private void InitComboBox()
        {
            _manufacturers = new List<Manufacturer>();
            _equipmentTypes = new List<EquipmentType>();
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
                case "textBoxSerialNumber":
                    var autoCompleteFName = new AutoCompleteStringCollection();
                    autoCompleteFName.AddRange(_repository.GetEntityes<Equipment>().
                        Where(eq => eq.Serial != null && eq.Serial.Contains(txBx.Text)).Select(eq => eq.Serial).ToArray());
                    txBx.AutoCompleteCustomSource = autoCompleteFName;
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


            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.FindEquipments(manufacturer, eqType,
                textBoxSerialNumber.Text, textBoxInventoryNumber.Text);
        }

        /// <summary>
        /// Обработка события нажатия кнопки сброса параметров поиска
        /// </summary>
        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        /// <summary>
        /// Выбор оборудования по двойному клику
        /// </summary>        
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            SelectedEquipment = dataGridView.SelectedRows[0].DataBoundItem as Equipment;
            if (SelectedEquipment != null)
            {
                DialogResult = DialogResult.OK;
            }
        }


    }
}
