using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Translator.Model;
using Translator.Core;

namespace Translator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowFromAll")]
    public class ValuesController : Controller
    {
        // POST api/values
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
