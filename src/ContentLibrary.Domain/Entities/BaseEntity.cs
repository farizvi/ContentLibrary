using System;

namespace ContentLibrary.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
