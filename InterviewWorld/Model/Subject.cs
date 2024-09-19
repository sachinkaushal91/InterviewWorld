using System.ComponentModel.DataAnnotations;

namespace InterviewWorld.Model
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        public int SubjectName { get; set; }
    }
}
