using Translator.Model;

namespace Translator.Core.Linux.Interfaces
{
    public interface ICommand 
    {
        string CreateStatement(Application application);

        string CreateStatements(Recipe recipe);
    }
}