#nullable disable
namespace Virtuous.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Donation
    {
        [Required(ErrorMessage = "Donation Id is required")]
        public int Id { get; set; }
        public Donor Donor { get; set; }
        [Display(Name = "Donation Amount", Prompt = "Donation Amount")]
        [Column(TypeName = "decimal(18,2)")] 
        public decimal Amount { get; set; }
        [Display(Name = "Cover Costs", Prompt = "Cover Costs?")]
        public bool IsCostCovered { get; set; }
        public CreditCard CreditCard { get; set; }
    }

    public class Donor
    {
        [Required(ErrorMessage = "Donor Id is required")]
        public int Id { get; set; }
        [Display(Name = "First Name", Prompt = "First Name")]
        public string FirstName { get; set; } = string.Empty;
        [Display(Name = "Last Name", Prompt = "Last Name")]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress]
        [Display(Name = "Email", Prompt = "Email Address")]
        public string Email { get; set; } = string.Empty;
        public Address Address { get; set; }
        [Display(Name = "Donated By")]
        public string Name => this.FirstName + " " + this.LastName;
    }

    public class CreditCard
    {
        [Required]
        public int CreditCardId { get; set; }
        [Display(Name = "Credit Card Number", Prompt = "Credit Card Number")]
        public string CreditCardNum { get; set; }
        [Display(Name = "CVV", Prompt = "CVV")]
        [Range(0,9999)]
        public string CVV { get; set; } = string.Empty;
        [Display(Name = "Expiration Date", Prompt = "mm/yyyy")]
        public string ExpirationDate { get; set; } = string.Empty;
        public string ExpiryYear => ExpirationDate?.IndexOf('/') > 0 ? ExpirationDate.Split('/')[1] : string.Empty;
        public string ExpiryMonth => ExpirationDate?.Split('/').FirstOrDefault() ?? string.Empty;
        public string CardType { get; set; } = string.Empty;
    }

    public enum CardType
    {
        MasterCard,
        Visa,
        AmericanExpress,
        Discover,
        JCB
    }

    public class Address
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Address", Prompt = "Full Address")]
        public string StreetAddress { get; set; } = string.Empty;
        [Display(Name = "City", Prompt = "City")]
        public string City { get; set; } = string.Empty;
        [Display(Name = "State", Prompt = "State")]
        public string State { get; set; } = string.Empty;
        [Display(Name = "Country", Prompt = "Country")]
        public string Country { get; set; } = string.Empty;
        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code", Prompt = "Zip Code")]
        public string ZipCode { get; set; } = string.Empty;
    }
}
