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
        private readonly ICommand git = new Git();

        public string Translate(Recipe recipe)
        {
            StringBuilder shellScript = new StringBuilder();
            shellScript.AppendLine(SHEBANG);

            try
            {
                shellScript.AppendLine(aptGet.CreateStatements(recipe));
                shellScript.AppendLine(git.CreateStatements(recipe));
                return shellScript.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}