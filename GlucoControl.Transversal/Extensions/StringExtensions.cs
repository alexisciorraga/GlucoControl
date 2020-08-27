using System.Text;
using System.Text.RegularExpressions;

namespace GlucoControl.Transversal.Extensions
{
    public static class StringExtensions
    {
        public static string GetTextSinDiacriticos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;

            var textoSinDiacriticos = texto.Normalize(NormalizationForm.FormD);
            var reg = new Regex("[^a-zA-Z0-9 ]");
            textoSinDiacriticos = reg.Replace(textoSinDiacriticos, "");

            return textoSinDiacriticos.Replace(" ", "").ToLower();
        }
    }
}