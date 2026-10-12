# prog2-fordonReg

## Download

Clone with submodules (HTTPS):

```bash
git clone --recurse-submodules https://github.com/sunbox-sudo/prog2-fordonReg.git
```

Or with SSH (requires an SSH key registered on GitHub):

```bash
git clone --recurse-submodules git@github.com:sunbox-sudo/prog2-fordonReg.git
```

## Troubleshooting

If `lib/utils` is empty and you get errors like these:

```text
warning MSB9008: The referenced project lib/utils/utils_dotnet.csproj does not exist.
error CS0246: The type or namespace name 'utils' could not be found (are you missing a using directive or an assembly reference?)
error CS0246: The type or namespace name 'OldMenu' could not be found (are you missing a using directive or an assembly reference?)
```

the submodule wasn't fetched. Run this inside the project folder:

```bash
git submodule update --init --recursive
```
