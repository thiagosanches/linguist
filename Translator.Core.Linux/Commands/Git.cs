using System;
using System.Text;
using Translator.Core.Interface;
using Translator.Core.Linux.Interfaces;
using Translator.Model;

namespace Translator.Core.Linux
{
    public class Git : ICommand
    {
        private const string GIT_CLONE_STATEMENT = "git clone {0}";
        private const string GIT_CREDENTIAL_HELPER_STATEMENT_ON = "git config --global credential.helper 'cache --timeout=3600'";
        private const string GIT_CREDENTIAL_HELPER_STATEMENT_OFF = "git credential-cache exit";
        public string CreateStatement(string repository)
        {
            return string.Format(GIT_CLONE_STATEMENT, repository);           
        }

        public string CreateStatement(Application packageName)
        {
            throw new NotImplementedException();
        }

        public string CreateStatements(Recipe recipe)
        {
            StringBuilder statements = new StringBuilder();
            statements.AppendLine(GIT_CREDENTIAL_HELPER_STATEMENT_ON);

            foreach (var repository in recipe.GitRepositories)
            {
                statements.AppendLine(CreateStatement(repository));
            }

            statements.AppendLine(GIT_CREDENTIAL_HELPER_STATEMENT_OFF);
            return statements.ToString();
        }
    }
}