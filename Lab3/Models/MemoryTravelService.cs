//using Data.Entities;

//namespace Labolatorium3_App.Models
//{
//    public class MemoryTravelService : ITravelService
//    {
//        private readonly Dictionary<int, Travel> _travels = new Dictionary<int, Travel>()
//        {
//            { 1, new Travel() { Id = 1, Name="New York - Warsaw", StartDate=new DateTime(2015, 10, 31), EndDate=new DateTime(2015, 11, 01), StartPlace="New York", EndPlace="Warsaw", Guide="Piotr Palik", Participants="Tomek" } },
//            { 2, new Travel() { Id = 2, Name="Praga - Krakow", StartDate=new DateTime(2016, 09, 22), EndDate=new DateTime(2016, 10, 04), StartPlace="Praga", EndPlace="Krakow", Guide="Janusz Gąska", Participants="Kasia" }  },
//        };

//        private int _id = 3;
//        public int Add(Travel travel)
//        {
//            travel.Id = _id++;
//            _travels[travel.Id] = travel;
//            return travel.Id;
//        }
//        public List<Travel>? FindAll()
//        {
//            return _travels.Values.ToList();
//        }
//        public Travel? FindById(int id)
//        {
//            return _travels[id];
//        }
//        public void Update(Travel travel)
//        {
//            _travels[travel.Id] = travel;
//        }
//        public void DeleteById(int id)
//        {
//            _travels.Remove(id);
//        }

//        public List<OrganizationEntity> FindAllOrganizations()
//        {
//            return _travels.Organizations.ToList();
//        }
//    }
//}
