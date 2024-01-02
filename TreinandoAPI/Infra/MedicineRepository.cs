using TreinandoAPI.Model;

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
    }
}
