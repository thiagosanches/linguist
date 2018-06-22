using System;
using System.Text;
using Translator.Model;
using Translator.Core.Windows.Interfaces;

namespace Translator.Core.Windows
{
    public class Chocolatey : ICommand
    {
        private const string INSTALL_CHOCOLATEY = @"Set-ExecutionPolicy Bypass -Scope Process -Force; 
                                            iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))";
        private const string INSTALLATION_STATEMENT = "choco install -y {0}";

        public string CreateStatement(Application application)
        {
            if (application.IsCustom)
                return application.Setup;
            else 
                return CreateStatement(application.Name);
        }

        public string CreateStatement(string name)
        {
            return string.Format(INSTALLATION_STATEMENT, name);
        }

        public string CreateStatements(Recipe recipe)
        {
            StringBuilder statement = new StringBuilder();
            statement.AppendLine(INSTALL_CHOCOLATEY);

            foreach (var item in recipe.Applications)
            {
                statement.AppendLine(CreateStatement(item));
            }

            return statement.ToString();
        }
    }
}