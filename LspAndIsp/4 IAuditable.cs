using System;

namespace LspAndIsp
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }
        string CreatedByUser { get; set; }
        DateTime? LastUpdatedDate { get; set; }
        string LastUpdatedByUser { get; set; }
    }
}
