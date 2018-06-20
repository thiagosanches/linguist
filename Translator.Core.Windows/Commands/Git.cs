using System;
using System.Text;
using Translator.Core.Interface;
using Translator.Core.Windows.Interfaces;
using Translator.Model;

namespace Translator.Core.Windows
{
    public class Git : ICommand
    {
        private const string GIT_CLONE_STATEMENT = "git clone {0}";
        private const string GIT_CREDENTIAL_HELPER_STATEMENT_ON = "git config --global credential.helper store";
        private const string GIT_CREDENTIAL_HELPER_STATEMENT_OFF = "git config --global --unset credential.helper; rm ~/.git-credentials";
        private const string GIT_ALIAS = @"Set-Alias git $env:programfiles\Git\bin\git.exe";
        public string CreateStatement(string repository)
        {
            StringBuilder statement = new StringBuilder();
            statement.AppendFormat(GIT_CLONE_STATEMENT, repository);           
            return statement.ToString();
        }

        public string CreateStatement(Application packageName)
        {
            throw new NotImplementedException();
        }

        public string CreateStatements(Recipe recipe)
        {
            StringBuilder statements = new StringBuilder();
            statements.AppendLine(GIT_ALIAS);
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