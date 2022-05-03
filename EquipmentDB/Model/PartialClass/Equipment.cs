using System.Linq;

namespace EquipmentDB.Model
{
    public partial class Equipment
    {
        public override string ToString()
        {
            return EquipmentType + " " + Manufacturer + " " + Model;
        }


        // EmployeeEquipments - сотрудники
        // RoomEquipments - помещения
        // WriteOffEquipments - списание

        /// <summary>
        /// Доступное количество оборудования на складе
        /// Кол-во на складе минус количество в эксплуатации минус оборудование на руках минус списанное
        /// </summary>
        public int Availability
        {
            get
            {
                return Quantity - RoomEquipmentsQuantity - EmployeeEquipmentsQuantity - WriteOffEquipmentsQuantity;
            }
        }

        /// <summary>
        /// Можно ли удалить оборудование с БД
        /// Количество должно быть равно количеству минус списанное
        /// </summary>
        public bool CanDelete
        {
            get { return Availability == Quantity - WriteOffEquipmentsQuantity; }
        }

        /// <summary>
        /// Количество оборудования во временном использовании
        /// </summary>
        public int EmployeeEquipmentsQuantity
        {
            get { return EmployeeEquipments.Where(empEq=>!empEq.EquipmentLeasing.IsArchive).Sum(eEq => eEq.Quantity); }
        }

        /// <summary>
        /// Количество оборудования в помещениях
        /// </summary>
        public int WriteOffEquipmentsQuantity
        {
            get { return WriteOffEquipments.Sum(wofEq => wofEq.Quantity); }
        }

        /// <summary>
        /// Количество оборудования в помещениях
        /// </summary>
        public int RoomEquipmentsQuantity
        {
            get { return RoomEquipments.Sum(rEq => rEq.Quantity); }
        }



        public override bool Equals(object obj)
        {
            var item = obj as Equipment;

            if (item != null)
            {
                return item.Equipment_ID == Equipment_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Equipment_ID;
        }
    }
}
