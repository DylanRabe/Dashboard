using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;


namespace Dashboard.Models
{
    public class Candidat
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(400)]
        public string Summary { get; set; } = string.Empty;

        public CVType CV { get; set; }

        public Gender Gender { get; set; }

        public DateTime Vide { get; set; }

        public DateTime? Complet { get; set; }
    }

    public enum Gender
    {
        Man,
        Woman,
    }

    public enum CVType
    {
        Competence ,
        Experience ,
        Language
    }
}
