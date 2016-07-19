# Fedirector
An F# web redirector.

### Requirements
* `nuget` (download from [nuget.org](http://www.nuget.org/))
* `fsi.exe` / `fsharpi` (see 'use' section at [fsharp.org](http://fsharp.org/))

### Preparing
Pull required packages from NuGet

	nuget install -ExcludeVersion Suave

### Editing
To add new urls for redirection you just need to add entries to the array in `app` creation. The pattern is

	path "/path/to/go/to" >=> redirect "http://where.to.redirect/"

To change the port edit `config.bindings` and replace `80` with the port you want.

### Running
On Windows

	fsi.exe app.fsx

On Linux

	fsharpi app.fsx

Then simply visit `http://localhost/path/to/go/to` and enjoy ;)
