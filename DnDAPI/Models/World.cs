namespace DnDAPI.Models
{
    public class World
    {
        public class NPC
        {
            public string Name { get; set; }
            public string About { get; set; }
            public string? Race { get; set; }
            public string? Quest { get; set; }
            public string? Occupation { get; set; }
        }
    }
}
