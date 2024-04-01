
using System.ComponentModel.DataAnnotations;

namespace SWD_ICQS.Entities
{
    public class PhuLucHopDong
    {
        [Key]
        public int id { get; set; }
        public int ContractId { get; set; }
        public string note {get; set; }

        public Contracts? Contract {  get; set; } 
    }
}
