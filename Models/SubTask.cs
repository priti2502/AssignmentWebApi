﻿using System.Text.Json.Serialization;

namespace AssignmentWebApi.Models
{
    public class SubTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int TaskId { get; set; }
        [JsonIgnore]
        public Tasks? Task { get; set; }
    }
}