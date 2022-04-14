#nullable disable
using Microsoft.EntityFrameworkCore;
using Virtuous.Web.Models;

namespace Virtuous.Data
{
    public class DonationRepository : IDonationRepository
    {
        private readonly VirtuousContext _dbContext;
        public DonationRepository(VirtuousContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Donation>> GetDonations() => await _dbContext.Donation.ToListAsync();
        public async Task<Donation> GetDonationById(int DonationId) => await _dbContext.Donation.FirstOrDefaultAsync(m => m.Id == DonationId);

        public async Task AddDonation(Donation donation)
        {
            if (donation == null) return;
            _dbContext.Donation.Add(donation);
            await _dbContext.SaveChangesAsync();
        }

        //This method is written but not being used. Only written to showcase try-catch
        public async Task UpdateDonation(Donation donation)
        {
            try
            {
                _dbContext.Update(donation);
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonationExists(donation.Id))
                {
                    return;
                }
                throw;
            }
        }
        private bool DonationExists(int id) => _dbContext.Donation.Any(e => e.Id == id);
    }
}