using System;
using System.Text;
using Translator.Model;
using Translator.Core.Windows.Interfaces;

namespace Translator.Core.Windows
{
    public class CustomCommand : ICommand
    {
        public string CreateStatement(Package packageName)
        {
            throw new NotImplementedException();
        }

        public string CreateStatements(PackageDefinition packageDefinition)
        {
            throw new NotImplementedException();
        }
    }
}