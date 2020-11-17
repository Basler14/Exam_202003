using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using BankApplication.Data.Models;
//Step 2. Create DTO class for the Client Model under the DTO folder add the validation for the mandatory parameters and String length and add validation messages
namespace BankApplication.Data.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You have to enter a Name")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You have to enter a Phone number")]
        [StringLength(400)]
        public string PhoneNumber { get; set; }

        public string Mail { get; set; }

        [Required(ErrorMessage = "You have to enter a type")]
        public ClientType Type { get; set; }
        

        [Required(ErrorMessage = "You have to add an Address.")]
        public int AddressId { get; set; }

        public virtual IEnumerable<AccountDTO> Accounts { get; set; }

    }
}
