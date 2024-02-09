
using Data;
using Data.Entities;
using Labolatorium3_App.Mappers;

namespace Labolatorium3_App.Models
{
    public class EFTravelService : ITravelService
    {
        private AppDbContext _context;

        public EFTravelService(AppDbContext context)
        {
            _context = context;
        }
        public int Add(Travel travel)
        {
            var e = _context.Travels.Add(TravelMapper.ToEntity(travel));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void DeleteById(int id)
        {
            TravelEntity? find = _context.Travels.Find(id);
            if (find != null)
            {
                _context.Travels.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Travel>? FindAll()
        {
            return _context.Travels.Select(e => TravelMapper.FromEntity(e)).ToList();
        }

        public Travel? FindById(int id)
        {
            return TravelMapper.FromEntity(_context.Travels.Find(id));
        }

        public void Update(Travel travel)
        {
            _context.Travels.Update(TravelMapper.ToEntity(travel));
            _context.SaveChanges();
        }

        public List<OrganizationEntity> FindAllOrganizations()
        {
            return _context.Organizations.ToList();
        }

        public List<GuideEntity> FindAllGuides()
        {
            return _context.Guides.ToList();
        }


        public GuideEntity FindGuideById(int guideId)
        {
            return _context.Guides.FirstOrDefault(g => g.Id == guideId);
        }

        public OrganizationEntity FindOrganizationById(int organizationId)
        {
            return _context.Organizations.FirstOrDefault(o => o.Id == organizationId);
        }

    }
}
