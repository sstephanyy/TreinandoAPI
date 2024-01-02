using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// a classe Medicine  é utilizada para regra de negócio (validações, métodos, etc), sendo assim, não é recomendável expor essa classe ao "mundo".  
namespace TreinandoAPI.Model
{
    [Table("Medicine")]
    public class Medicine
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int StockQuantity { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public string DosageForm { get; private set; }
        public string Composition { get; private set; }
        public string Manufacturer { get; private set; }


        // Foreign key referencing Supplier entity
        public int SupplierID { get; set; }
        //public Supplier Supplier { get; set; }

        public Medicine(
           string name,
           string category,
           string composition,
           string dosageForm,
           decimal unitPrice,
           int stockQuantity,
           DateTime expiryDate,
           string manufacturer,
           int supplierID
       )
        {
            this.Name = name;
            this.Category = category;
            this.Composition = composition;
            this.DosageForm = dosageForm;
            this.UnitPrice = unitPrice;
            this.StockQuantity = stockQuantity;
            this.ExpiryDate = expiryDate;
            this.Manufacturer = manufacturer;
            this.SupplierID = supplierID;
        }
    }
}
