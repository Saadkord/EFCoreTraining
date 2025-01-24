namespace EFCoreTraining.Entity
{
    public class Section
    {
        public int Id { get; set; }
        public string? SectionName { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
