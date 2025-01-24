namespace EFCoreTraining.Entity
{
    public class Professor
    {
        public int Id { get; set; }
        public string? FirsName {  get; set; }
        public string? LastName { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public string FullName  => $"{FirsName} {LastName}";
        public override string ToString()
        {
            return FullName;
        }
    }
}
