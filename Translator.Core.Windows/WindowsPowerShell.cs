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
        private readonly ICommand git = new Git();

        public string Translate(Recipe recipe)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(chocolatey.CreateStatements(recipe));
                stringBuilder.AppendLine(git.CreateStatements(recipe));

                return stringBuilder.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}