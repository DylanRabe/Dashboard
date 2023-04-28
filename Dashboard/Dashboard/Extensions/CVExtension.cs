using Dashboard.Models;

namespace Dashboard.Extensions
{
    public static class CVExtension
    {
        static readonly Dictionary<CVType, string> _cvCssClasses = new()
        {
            [CVType.Language] = "badge bg-danger",
            [CVType.Competence] = "badge bg-warning text-dark",
            [CVType.Experience] = "badge bg-success",
        };
        //new method pour retourner un string qui represente une classe css a utiliser pour afficher un badge
        public static string ToCssClass(this CVType CV)
        {
           return  _cvCssClasses[CV];
        }

    }
}
