using Virtuous.Web.Models;

namespace Virtuous.Data
{
    public interface IDonationRepository
    {
        Task<IEnumerable<Donation>> GetDonations();
        Task<Donation> GetDonationById(int DonationId);
        Task AddDonation(Donation donation);
        Task UpdateDonation(Donation donation);
    }
}