using System;

namespace Not
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedByUser { get; set; }
        DateTime? LastUpdatedDate { get; set; }
        string LastUpdatedByUser { get; set; }
    }
}
