using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Translator.Model;
using Translator.Core;

namespace Translator.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpPost]
        [EnableCors("AllowFromAll")]
        public string Post([FromBody]Recipe recipe)
        {
            try
            {
                Resolver resolver = new Resolver();
                return resolver.Translate(recipe);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
