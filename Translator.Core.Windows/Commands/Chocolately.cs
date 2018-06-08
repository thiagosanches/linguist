using System;
using System.Text;
using Translator.Model;
using Translator.Core.Windows.Interfaces;

namespace Translator.Core.Windows
{
    public class Chocolately : ICommand
    {
        private const string CHOCOLATELY_DEPENDENCY = "Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))";
        private const string INSTALLATION_STATEMENT = "choco install -y {0}";
        private const string NEWLINE = "\r\n";
        private static bool AlreadyDefinedChocolatelyDependency { get; set; }

        public string CreateStatement(string packageName)
        {
            string statement = string.Empty;

            if(!AlreadyDefinedChocolatelyDependency)
            {
                statement += string.Format("{0}{1}", CHOCOLATELY_DEPENDENCY, NEWLINE);
                AlreadyDefinedChocolatelyDependency = true;
            }           

            statement += string.Format(INSTALLATION_STATEMENT, 
                packageName);

            return statement;
        }

        public string CreateStatements(PackageDefinition packageDefinition)
        {
            StringBuilder statement = new StringBuilder();

            foreach (var item in packageDefinition.Packages)
            {
                statement.AppendLine(CreateStatement(item));
            }

            return statement.ToString();
        }
    }
}