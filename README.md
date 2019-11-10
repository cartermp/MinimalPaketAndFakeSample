# MinimalPaketAndFakeSample

Shows a minimal usage of modern paket and fake.

Run via:

```
./build.sh
```

Or if you're on Windows:

```
build.cmd
```

## Adding new packages

To add new packages, list them in the `paket.dependencies` file and then run this command:

```
dotnet paket install
```

Make sure to include any dependencies you want per-project in the `paket.references` files.

## Updating packages

To update packages, run this command:

```
dotnet paket update
```

This will update all packages you depend on.
