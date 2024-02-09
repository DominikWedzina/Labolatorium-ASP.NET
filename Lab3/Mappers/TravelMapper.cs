using Data.Entities;
using Labolatorium3_App.Models;

namespace Labolatorium3_App.Mappers
{
    public class TravelMapper
    {
        public static Travel FromEntity(TravelEntity travel)
        {
            return new Travel
            {
                Id = travel.Id,
                Name = travel.Name,
                StartDate = travel.StartDate,
                EndDate = travel.EndDate,
                StartPlace = travel.StartPlace,
                EndPlace = travel.EndPlace,
                Participants = travel.Participants,
                GuideId = travel.GuideId,
                OrganizationId = travel.OrganizationId
            };
        }

        public static TravelEntity ToEntity(Travel model)
        {
            return new TravelEntity
            {
                Id = model.Id,
                Name = model.Name,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                StartPlace = model.StartPlace,
                EndPlace = model.EndPlace,
                Participants = model.Participants,
                GuideId = model.GuideId,
                OrganizationId = model.OrganizationId
            };
        }
    }
}
