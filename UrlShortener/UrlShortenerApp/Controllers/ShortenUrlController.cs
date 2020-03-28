using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UrlShortenerApp.Extension;

namespace UrlShortenerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShortenUrlController : ControllerBase
    {
        [HttpPost]
        public string Post([FromBody] string url)
        {
            string _shortURL   =  url.ToShortURL();
            return  _shortURL;
              
        }
    }
}