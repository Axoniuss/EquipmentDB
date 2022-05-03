using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms.AddEditForms;
using EquipmentDB.Model;

namespace EquipmentDB.Forms.MainForms
{
    public partial class RoomEquipmentForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;
        
        private List<Manufacturer> _manufacturers;
        private List<EquipmentType> _equipmentTypes;
        private List<BalanceType> _balanceTypes;
        private List<Corps> _corps;

        private Equipment _equipment;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public RoomEquipmentForm(Equipment equipment)
        {
            _equipment = equipment;
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public RoomEquipmentForm():this(null)
        {

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
                var item = dataGridView.SelectedRows[0].DataBoundItem as RoomEquipment;
                new AddEditRoomEquipmentForm(item).ShowDialog();
                UpdateDatagrid();
            }
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as RoomEquipment;
                var result = MessageBox.Show("Удалить запись с ID " + item.Room_ID + " и вернуть оборудование на склад?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
            new AddEditRoomEquipmentForm().ShowDialog();
            UpdateDatagrid();
        }
        
        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        private void RoomsForm_Load(object sender, EventArgs e)
        {
            _manufacturers = new List<Manufacturer>();
            _equipmentTypes = new List<EquipmentType>();
            _balanceTypes = new List<BalanceType>();
            _corps = new List<Corps>();
            InitComboBox();
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события нажатия кнопки сброса фильтра
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxManufacturers.SelectedItem = _manufacturers.First();
            comboBoxEquipType.SelectedItem = _equipmentTypes.First();
            comboBoxBalanceType.SelectedItem = _balanceTypes.First();
            comboBoxCorps.SelectedItem = _corps.First();
            textBoxEquipmentName.Clear();
            textBoxInventoryNumber.Clear();
            textBoxSerialNumber.Clear();
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
            if (_equipment!=null)
            {
                dataGridView.DataSource = _repository.GetEntityes<RoomEquipment>(re =>re.Equipment_ID==_equipment.Equipment_ID );
                _equipment = null;
            }
            else
            {
                dataGridView.DataSource = _repository.GetEntityes<RoomEquipment>();  
            }
            dataGridView.ClearSelection();
        }


        /// <summary>
        /// Инициализация источника данных для combobox (корпуса)
        /// </summary>
        private void InitComboBox()
        {
           // ------------------------------------------------
            _manufacturers.Add(new Manufacturer() { ManufacturerName = "Все производители" });
            _manufacturers.AddRange(_repository.GetEntityes<Manufacturer>());
            comboBoxManufacturers.DataSource = _manufacturers;
            
            // ------------------------------------------------
            _equipmentTypes.Add(new EquipmentType() { EquipmentTypeName = "Все типы оборудования" });
            _equipmentTypes.AddRange(_repository.GetEntityes<EquipmentType>());
            comboBoxEquipType.DataSource = _equipmentTypes;

            // ------------------------------------------------
            _balanceTypes.Add(new BalanceType() { BalanceTypeName = "Все типы учёта" });
            _balanceTypes.AddRange(_repository.GetEntityes<BalanceType>());
            comboBoxBalanceType.DataSource = _balanceTypes;
           
            // ------------------------------------------------
            _corps.Add(new Corps() { CorpsName = "Все корпуса" });
            _corps.AddRange(_repository.GetEntityes<Corps>());
            comboBoxCorps.DataSource = _corps;
           
        }

        #endregion

        /// <summary>
        /// Обработка события нажатия кнопки поиска
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var manufacturer = comboBoxManufacturers.SelectedItem as Manufacturer;
            var eqType = comboBoxEquipType.SelectedItem as EquipmentType;
            var balanceType = comboBoxBalanceType.SelectedItem as BalanceType;
            var corps = comboBoxCorps.SelectedItem as Corps;
            var room = comboBoxRoom.SelectedItem as Room;
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.FindRoomEquipments(manufacturer, eqType, balanceType,
                textBoxSerialNumber.Text, textBoxInventoryNumber.Text, textBoxEquipmentName.Text, corps, room);
        }
        /// <summary>
        /// Обработка события выбора корпуса
        /// </summary>
        private void comboBoxCorps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var corp = comboBoxCorps.SelectedItem as Corps;
            if (corp!=null&&corp.Corps_ID>0)
            {
                var rooms=new List<Room>(){new Room(){RoomName = "Все помещения корпуса"}};
                rooms.AddRange(_repository.GetEntityes<Room>(room => room.Corps_ID==corp.Corps_ID));
                comboBoxRoom.DataSource = rooms;
                comboBoxRoom.SelectedItem = rooms.First();
            }
            else
            {
                comboBoxRoom.DataSource = null;
            }
        }

       

    }
}
