namespace Labolatorium3_App.Models
{
    public interface ITravelService
    {
        void Add(Travel contact);
        void Update(Travel contact);
        void DeleteById(int id);
        Travel? FindById(int id);
        List<Travel>? FindAll();
    }
}
