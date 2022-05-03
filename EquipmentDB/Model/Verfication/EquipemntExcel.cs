using System.Linq;

namespace EquipmentDB.Model.Verfication
{
    public enum EquipLocationStatus
    {
        InStock,
        InEmployee,
        InRoom,
        WriteOff,
        Unknown
    }

    public class EquipemntExcel
    {
        public string Num { get; set; }

        public string EquipmentNameExcel { get; set; }

        public string InventoryNumberExcel { get; set; }

        public Equipment Equipment { get; set; }

        public EquipLocationStatus EquipLocationStatus
        {
            get
            {
                if (Equipment == null) return EquipLocationStatus.Unknown;

                if (Equipment.EmployeeEquipments.Any())
                {
                    return EquipLocationStatus.InEmployee;
                }
                if (Equipment.RoomEquipments.Any())
                {
                    return EquipLocationStatus.InRoom;
                }

                if (Equipment.WriteOffEquipments.Any())
                {
                    return EquipLocationStatus.WriteOff;
                }
                return EquipLocationStatus.InStock;
            }
        }

        public string EquipmentLocation
        {
            get
            {
                if (Equipment == null) return "Не найдено";

                if (Equipment.EmployeeEquipments.Any())
                {
                    return Equipment.EmployeeEquipments.First().EquipmentLeasing.Employee1.ToString();
                }
                if (Equipment.RoomEquipments.Any())
                {
                    return Equipment.RoomEquipments.First().Room.ToString();
                }

                if (Equipment.WriteOffEquipments.Any())
                {
                    var wrEquip = Equipment.WriteOffEquipments.First();
                    return "Списано " + wrEquip.OrderDate.ToShortDateString() + "г.  (приказ №" + wrEquip.OrderNumber + ")";
                }
                return "На складе";
            }

        }
    }
}
