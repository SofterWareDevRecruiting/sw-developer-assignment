using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  UrlShortenerApp.Token;
namespace UrlShortenerApp.Extension
{
    public static class StringExtension
    {

        public static string ToShortURL(this string url)
        {
            string _shortURL = string.Empty;
            Uri uri = new Uri(url);
           _shortURL  = url.Replace(uri.AbsolutePath , "/"+ Tokenization.GenerateToken());

            return _shortURL;
        }



    }
}
