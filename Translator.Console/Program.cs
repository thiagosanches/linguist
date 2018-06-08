using System;
using Translator.Core;
using Translator.Model;

namespace Translator.Console 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            PackageDefinition packageDefinition = new PackageDefinition();
            packageDefinition.OperatingSystem = "LINUX";
            packageDefinition.Packages = new string[] { "vscode", "git" };

            Resolver resolver = new Resolver();
            System.Console.WriteLine(resolver.Translate(packageDefinition));
        }
    }
}