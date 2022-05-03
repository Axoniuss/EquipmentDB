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
        /// Загрузка данных оборудования с файла Excel
        /// </summary>
        public EquipmentVerificator LoadFromExcelFile(string path, int skipRows)
        {
            var book = new ExcelQueryFactory(path);
            _verificationList = (from x in book.Worksheet(0)
                    select new EquipemntExcel()
                    {
                        Num = x["N_п/п"],
                        EquipmentNameExcel = x["Наименование объекта нефинансового актива"],
                        InventoryNumberExcel = x["Номер (код) объекта учета (инвентарный или иной)"]
                    }).
                Skip(skipRows).
                ToList();
            return this;
        }

        /// <summary>
        /// Загрузка данных оборудования с базы данных
        /// </summary>
        public EquipmentVerificator LoadEquipmentFromRepository(IRepository repository, int balanceTypeId)
        {
            _equipmentsList = repository.GetEntityes<Equipment>(equipment => equipment.BalanceType_ID == balanceTypeId);
            return this;
        }

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
