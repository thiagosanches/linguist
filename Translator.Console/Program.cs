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
            List<Application> applications = new List<Application>();
            applications.Add(new Application(){ Name = "git" });
            applications.Add(new Application(){ Name = "vscode" });

            Recipe recipe = new Recipe();
            recipe.OperatingSystem = "LINUX";
            recipe.Applications = applications;
            recipe.GitRepositories = new string[]{ "https://thiagom_cit@bitbucket.org/ciandt_it/brandscom.git", 
                "https://thiagom_cit@bitbucket.org/ciandt_it/ccna-dev-ops.git" };

            Resolver resolver = new Resolver();
            System.Console.WriteLine(resolver.Translate(recipe));
        }
    }
}