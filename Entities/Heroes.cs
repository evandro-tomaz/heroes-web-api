namespace HeroesWebAPI.Entities
{
    public class Heroes
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Active { get; set; }
    }
}