using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Transaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransectionId { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Code { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }  
    }
}
