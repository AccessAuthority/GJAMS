using System.ComponentModel.DataAnnotations;

namespace GJAMS.Models
{
    public class AdminTable
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
