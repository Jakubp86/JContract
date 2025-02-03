using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Application.Contract
{
    public class ContractDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string? NrUmowy { get; set; }
        public string? Type { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
}
