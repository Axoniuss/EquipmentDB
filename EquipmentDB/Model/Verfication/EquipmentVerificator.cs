using System.Collections.Generic;
using System.Linq;
using EquipmentDB.Controller;
using LinqToExcel;

namespace EquipmentDB.Model.Verfication
{
    public class EquipmentVerificator
    {
        private List<EquipemntExcel> _verificationList;
        private List<Equipment> _equipmentsList;

   

        /// <summary>
        /// Загрузка данных оборудования с базы данных
        /// </summary>

        public List<EquipemntExcel> Verificate()
        {
            foreach (var equipemntExcel in _verificationList)
            {
                var item = _equipmentsList.Find(equipment => equipment.InventoryNumber.ToLower().Trim(' ') == equipemntExcel.InventoryNumberExcel.ToLower().Trim(' '));
                if (item != null)
                {
                    equipemntExcel.Equipment = item;
                }
            }
            return _verificationList.ToList();
        }

    }
}
