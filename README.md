# linguist

linguist (\ˈliŋ-gwist\\): a person skilled in foreign languages.

The main purpose is to create a kind of translator that receives a known json and return a script considering the destiny platform (Linux, Windows or Mac).

The idea is to help managing some setup scripts to development machines, exposing an API that can be used on front-end applications to build a better UX to the final user.

## Example

### Input
```
{
  "OS": "LINUX",
  "packages": ["git"]
}
```

### Linux Output
```
#!/bin/bash
sudo apt-get install -y git
```

The linguist support only apt-get on Linux and chocolatey on Windows plataform it's mandatory to install it (the script handle that).

## Dependencies
* apt-get (Debian based distros)
* chocolatey (Windows 7+) [https://chocolatey.org/]
