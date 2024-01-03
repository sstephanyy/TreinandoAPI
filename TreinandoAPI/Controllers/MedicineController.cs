using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreinandoAPI.Model;
using TreinandoAPI.ViewModel;

namespace TreinandoAPI.Controllers
{
    [ApiController]
    [Route("api/medicine")]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineRepository _mediicineRepository;

        public MedicineController(IMedicineRepository medicineRepository)
        {
            _mediicineRepository = medicineRepository ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public IActionResult Add(MedicineViewModel medicineView)
        {
            var medicine = new Medicine(medicineView.Name, medicineView.Category, medicineView.Manufacturer, medicineView.DosageForm, medicineView.UnitPrice, medicineView.StockQuantity, medicineView.ExpiryDate, medicineView.Composition, medicineView.SupplierID);


            _mediicineRepository.Add(medicine);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var medicines = _mediicineRepository.Get();

            return Ok(medicines);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _mediicineRepository.Delete(id);

            return Ok();
        }
    }
}
