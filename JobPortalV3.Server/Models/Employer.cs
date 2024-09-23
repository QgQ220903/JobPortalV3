using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalV3.Server.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        [ForeignKey("Company")]
        public int CompanyId {  get; set; }
        public Company Company { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;}
        public int Status { get; set; }
    }
}
