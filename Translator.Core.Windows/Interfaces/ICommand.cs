using Translator.Model;

namespace Translator.Core.Windows.Interfaces
{
    public interface ICommand 
    {
        string CreateStatement(Package package);

        string CreateStatements(PackageDefinition packageDefinition);
    }
}