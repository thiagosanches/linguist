# linguist

linguist (\ˈliŋ-gwist\\): a person skilled in foreign languages.

The main purpose is to create a kind of translator that receives a known json and return a script considering the destiny platform (Linux, Windows or Mac).

The idea is to help manage some setup scripts to development machines, exposing an API that can be used on front-end applications to build a better UX to the final user.

For linux scripts it's considering to return a plain-text bash script and for Windows a Windows Powershell.

Basically, we are supporting only apt-get on Linux and on Windows plataform it's mandatory to use the chocolatey application.

## Example

### Input
```
{
  "operationSystem": "LINUX",
  "packages": ["git"]
}
```

### Linux Output
```
#!/bin/bash
sudo apt-get install -y git
```
