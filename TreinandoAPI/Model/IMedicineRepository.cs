namespace TreinandoAPI.Model
{
    public interface IMedicineRepository
    {
        void Add(Medicine medicine);

        List<Medicine> Get();
    }
}
