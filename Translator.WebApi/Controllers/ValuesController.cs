using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Translator.Model;
using Translator.Core;

namespace Translator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowFromAll")]
    public class ValuesController : Controller
    {
        [HttpPost]
        public string Post([FromBody]PackageDefinition packageDefinition)
        {
            try
            {
                Resolver resolver = new Resolver();
                return resolver.Translate(packageDefinition);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
