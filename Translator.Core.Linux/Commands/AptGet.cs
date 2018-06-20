using System;
using System.Text;
using Translator.Core.Interface;
using Translator.Core.Linux.Interfaces;
using Translator.Model;

namespace Translator.Core.Linux
{
    public class AptGet : ICommand
    {
        private const string INSTALL_STATEMENT = "apt-get install -y {0}";

        public string CreateStatement(Application application)
        {
            StringBuilder statement = new StringBuilder();

            statement.AppendFormat(INSTALL_STATEMENT, application.Name);
            
            return statement.ToString();
        }

        public string CreateStatements(Recipe recipe)
        {
            StringBuilder statement = new StringBuilder();

            foreach (var item in recipe.Applications)
            {
                statement.AppendLine(CreateStatement(item));
            }

            return statement.ToString();
        }
    }
}
