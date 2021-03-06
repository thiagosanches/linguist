﻿using System;
using Translator.Model;
using Translator.Core.Interface;
using Translator.Core.Linux;
using Translator.Core.Windows;

namespace Translator.Core
{
    public class Resolver
    {
        private static ITranslator translator;

        public string Translate(Recipe recipe)
        {
            InjectDependency(recipe.OperatingSystem);
            return translator.Translate(recipe);
        }

        //A very dumb dependency injector mechanism. TODO: use a inject dependency container.
        private void InjectDependency(string operatingSystem)
        {
            switch (operatingSystem.ToLower())
            {
                case "linux":
                    translator = new Translator.Core.Linux.Bash();
                    break;
                case "windows":
                    translator = new Translator.Core.Windows.WindowsPowerShell();
                    break;
            }
        }
    }
}
