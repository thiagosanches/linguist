using Translator.Model;

namespace Translator.Core.Windows.Interfaces
{
    public interface ICommand 
    {
        string CreateStatement(string packageName);

        string CreateStatements(PackageDefinition packageDefinition);
    }
}