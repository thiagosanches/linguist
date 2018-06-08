using System;
using System.Text;
using Translator.Model;
using Translator.Core.Interface;
using Translator.Core.Linux.Interfaces;

namespace Translator.Core.Linux
{
    public class Bash : ITranslator
    {
        private const string SHEBANG = "#!/bin/bash";
        private readonly ICommand aptGet = new AptGet();

        public string Translate(PackageDefinition packageDefinition)
        {
            StringBuilder shellScript = new StringBuilder();
            shellScript.AppendLine(SHEBANG);

            try
            {
                shellScript.AppendLine(aptGet.CreateStatements(packageDefinition));
                return shellScript.ToString();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}