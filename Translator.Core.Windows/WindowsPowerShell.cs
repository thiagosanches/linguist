using System;
using System.Text;
using Translator.Model;
using Translator.Core.Interface;
using Translator.Core.Windows.Interfaces;

namespace Translator.Core.Windows
{
    public class WindowsPowerShell : ITranslator
    {
        private readonly ICommand chocolately = new Chocolately();

        public string Translate(PackageDefinition packageDefinition)
        {
            try
            {
                return chocolately.CreateStatements(packageDefinition);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}