using System;
using Translator.Model;
using Translator.Core.Interface;
using Translator.Core.Linux;
using Translator.Core.Windows;

namespace Translator.Core
{
    public class Resolver
    {
        private static ITranslator translator;

        public string Translate(PackageDefinition packageDefinition)
        {
            InjectDependency(packageDefinition.OperatingSystem);
            return translator.Translate(packageDefinition);
        }

        //A very dumb dependency injector mechanism. TODO: use a inject dependency container.
        private void InjectDependency(string operationSystem)
        {
            switch (operationSystem)
            {
                case "LINUX":
                    translator = new Translator.Core.Linux.Bash();
                    break;
                case "WINDOWS":
                    translator = new Translator.Core.Windows.WindowsPowerShell();
                    break;
            }
        }
    }
}
