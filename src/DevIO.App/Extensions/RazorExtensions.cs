using Microsoft.AspNetCore.Mvc.Razor;
using System;

namespace DevIO.App.Extensions
{
    public static class RazorExtensions
    {
        public static string FormataDocumento(this RazorPage page, int tipoPessoa, string documento)
        {
            if(tipoPessoa == 1 && documento.Length == 11)
            {
                return Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00");
            }
                return Convert.ToUInt64(documento).ToString(@"00\.000\.000\/0000\-00");
        }
    }
}
