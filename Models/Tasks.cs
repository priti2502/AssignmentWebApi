using System.Text.Json.Serialization;

namespace AssignmentWebApi.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<SubTask>? SubTasks { get; set; }
    }
}