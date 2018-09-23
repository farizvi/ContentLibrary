using System;

namespace ContentLibrary.WebAPI.Models
{
    public class EntityModel
    {
        public int EntityId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}