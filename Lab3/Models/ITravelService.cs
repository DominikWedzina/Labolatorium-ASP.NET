using Data.Entities;

namespace Labolatorium3_App.Models
{
    public interface ITravelService
    {
        int Add(Travel travel);
        void Update(Travel travel);
        void DeleteById(int id);
        Travel? FindById(int id);
        List<Travel>? FindAll();
        List<GuideEntity> FindAllGuides();
        List<OrganizationEntity> FindAllOrganizations();
        GuideEntity FindGuideById(int guideId);
        OrganizationEntity FindOrganizationById(int organizationId);
    }
}
