using Data;
using Data.Entities;
namespace Labolatorium3_App.Models
{
    public class ContactMapper
    {
    static public Contact FromEntity(ContactEntity entity)
    {
        return new Contact()
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email,
            Phone = entity.Phone,
            Birth = entity.Birth,
            Priority = (Priority)entity.Priority,
        };
    }

    static public ContactEntity ToEntity(Contact entity)
        {
            return new ContactEntity()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                Birth = entity.Birth,
                Priority = (int)entity.Priority,
            };
        }

    }
}
