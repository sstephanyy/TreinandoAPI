using TreinandoAPI.Model;
using TreinandoAPI.ViewModel;

namespace TreinandoAPI.Infra
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Medicine medicine)
        {
            _context.Medicines.Add(medicine);
            _context.SaveChanges();
        }

        public List<Medicine> Get()
        {
            return _context.Medicines.ToList();
        }

        public void Delete(int id)
        {
            var medicine = _context.Medicines.Find(id);

            if (medicine != null)
            {
                _context.Medicines.Remove(medicine);
                _context.SaveChanges();
            }
         
        }
        public void Update(int id, MedicineViewModel updatedMedicine)
        {
            var existingMedicine = _context.Medicine.Find(id);

            if (existingMedicine != null)
            {
                // Update the existing medicine with new values
                existingMedicine.Name = updatedMedicine.Name;
                existingMedicine.Category = updatedMedicine.Category;
                existingMedicine.Manufacturer = updatedMedicine.Manufacturer;
                existingMedicine.DosageForm = updatedMedicine.DosageForm;
                existingMedicine.UnitPrice = updatedMedicine.UnitPrice;
                existingMedicine.StockQuantity = updatedMedicine.StockQuantity;
                existingMedicine.ExpiryDate = updatedMedicine.ExpiryDate;
                existingMedicine.Composition = updatedMedicine.Composition;
                existingMedicine.SupplierID = updatedMedicine.SupplierID;

                // Update other properties as needed...

                _context.SaveChanges();
            }
        }



    }
}
