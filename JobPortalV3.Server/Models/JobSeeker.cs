using System.ComponentModel.DataAnnotations;

namespace JobPortalV3.Server.Models
{
    public class JobSeeker
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? email { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Status { get; set; }
    }
}
