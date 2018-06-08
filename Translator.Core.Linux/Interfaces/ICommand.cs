using Translator.Model;

namespace Translator.Core.Linux.Interfaces
{
    public interface ICommand 
    {
        string CreateStatement(string packageName);

        string CreateStatements(PackageDefinition packageDefinition);
    }
}