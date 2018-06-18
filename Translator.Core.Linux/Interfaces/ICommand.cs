using Translator.Model;

namespace Translator.Core.Linux.Interfaces
{
    public interface ICommand 
    {
        string CreateStatement(Package packageName);

        string CreateStatements(PackageDefinition packageDefinition);
    }
}