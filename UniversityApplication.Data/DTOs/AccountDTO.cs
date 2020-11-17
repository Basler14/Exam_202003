using System.ComponentModel.DataAnnotations;

using BankApplication.Data.Models;
//Step 5: Create DTO class for Accounts and add the validation for the mandatory parameters and String length and add validation messages
namespace BankApplication.Data.DTOs
{
    public class AccountDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You have to enter a Name")]
        [StringLength(200)]
        public string Name { get; set; }

        public decimal Balance { get; set; }

        [Required(ErrorMessage = "You have to enter a type")]
        public AccountType Type { get; set; }

        public bool IsActive { get; set; }


        [Required(ErrorMessage = "You have to add an Client")]
        public int ClientId { get; set; }


        public virtual ClientDTO Exam { get; set; }
    }
}
