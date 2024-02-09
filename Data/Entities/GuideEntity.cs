namespace Data.Entities
{
    public class GuideEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Languages { get; set; }
        public Address? Address { get; set; }

        public ISet<TravelEntity> Travels { get; set; }

    }
}
