using Delegate.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Models
{
    internal class Pharmacy
    {
        public int MedicineLimit { get; set; }
        private List<Medicine> _Medicines;
        private object _medicines;

        public Pharmacy(int medicineLimit )
        {
            _Medicines = new List<Medicine>();
            MedicineLimit= medicineLLimit
        }

        public void AddMedicine(Medicine medicine)
        {
            if (_medicines.Exists(m => m.Name == medicine.Name && !m.IsDeleted))
                throw new MedicineAlreadyExistsException("bu adda derman var");

            if(_medicines.Count < MedicineLimit)
            {
                _medicines.Add(medicine);
                return;
            }

            throw new CapacityLimitException("limit dolub");
       
    }
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> list = new List<Medicine>();
            medicinesCopy.AddRange(_medicines.FindAll(m => !m.IsDeleted));
            return list;
        }
         public List<Medicine> FilterMedicinesByPrice(double minPrice, double maxPrice)
        {
            return _medicines.FindAll(m => !m.IsDeleted && m.Price >= minPrice && m.Price <= maxPrice);
        }
         public Medicine GetMedicineById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            return _medicines.Find(m => !m.IsDeleted && m.Id == id);
        }

}
