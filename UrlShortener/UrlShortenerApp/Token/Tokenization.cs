using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortenerApp.Token
{
    public class Tokenization
    {

        
        public static string GenerateToken()
        {
            // although its a useless way you can just 
            StringBuilder urlsafe = new StringBuilder();
            string _token = string.Empty;
            // Collect numbers  in the box
            var numbers = Enumerable.Range(48, 75)
             .Where(i => i < 58 || i > 64 && i < 91 || i > 96);
            // Get each random number Shake the box
            var RandomNumbersInSequence = numbers.OrderBy(o => new Random().Next())
             .ToList();
            // Convert eas

            // Convert each into a character and append all characters
            RandomNumbersInSequence.ForEach(i => urlsafe.Append(Convert.ToChar(i))); // Store each char into urlsafe

            // pick a random substring of 4 length 
            _token = urlsafe.ToString().Substring(new Random().Next(0, urlsafe.Length), new Random().Next(2, 6));
            return _token;

        }

    }
}
