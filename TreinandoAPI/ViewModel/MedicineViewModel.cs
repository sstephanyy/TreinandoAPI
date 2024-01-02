namespace TreinandoAPI.ViewModel
{
    public class MedicineViewModel
    {
        public string Name { get;  set; }

        public string Category { get; set; }

        public decimal UnitPrice { get;  set; }

        public int StockQuantity { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string DosageForm { get; set; }

        public string Composition { get; set; } 

        public string Manufacturer { get;  set; }

        public int SupplierID { get; set; }


    }
}
