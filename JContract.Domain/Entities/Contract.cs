using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Domain.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string? NrUmowy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ContactDetails ContactDetails { get; set; } = default!;
        public string? Type { get; set; }
    }
}
