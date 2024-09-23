using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalV3.Server.Models
{
    public class Skill
    {
        // Primary key [Key]
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; }
    }
}
