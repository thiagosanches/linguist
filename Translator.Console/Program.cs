using System;
using System.Collections.Generic;
using Translator.Core;
using Translator.Model;

namespace Translator.Console 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            List<Package> packages = new List<Package>();
            packages.Add(new Package(){ Name = "git" });
            packages.Add(new Package(){ Name = "vscode" });

            PackageDefinition packageDefinition = new PackageDefinition();
            packageDefinition.OperatingSystem = "LINUX";
            packageDefinition.Packages = packages;

            Resolver resolver = new Resolver();
            System.Console.WriteLine(resolver.Translate(packageDefinition));
        }
    }
}