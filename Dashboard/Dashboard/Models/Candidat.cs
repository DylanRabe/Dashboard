using System.Security.Claims;
using Microsoft.EntityFrameworkCore;


namespace Dashboard.Models
{
    public class Candidat
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
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
