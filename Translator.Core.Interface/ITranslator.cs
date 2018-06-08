using System;
using Translator.Model;

namespace Translator.Core.Interface
{
    public interface ITranslator
    {
        string Translate(PackageDefinition packageDefinition);
    }
}
