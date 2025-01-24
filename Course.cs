

namespace EFCoreTraining.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourceName { get; set; }
        public int Price { get; set; }
        public List<Section> Sections { get; set; } = new List<Section>();
        public Professor? Professor { get; set; }

        public override string ToString()
        {
            return $"{Id} => {CourceName} {Price}";
        }
    }
}
