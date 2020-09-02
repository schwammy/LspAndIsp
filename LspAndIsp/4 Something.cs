using System;

namespace LspAndIsp
{
    public class Something : IIntId, IAuditable
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedByUser { get; set; }
    }
}
