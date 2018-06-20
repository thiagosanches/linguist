using Translator.Model;

namespace Translator.Core.Windows.Interfaces
{
    public interface ICommand 
    {
        string CreateStatement(string name);
        string CreateStatement(Application package);
        string CreateStatements(Recipe recipe);
    }
}