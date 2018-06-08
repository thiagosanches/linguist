using System;
using System.Text;
using Translator.Model;
using Translator.Core.Interface;
using Translator.Core.Windows.Interfaces;

namespace Translator.Core.Windows
{
    public class WindowsPowerShell : ITranslator
    {
        private readonly ICommand chocolatey = new Chocolatey();

        public string Translate(PackageDefinition packageDefinition)
        {
            try
            {
                return chocolatey.CreateStatements(packageDefinition);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}