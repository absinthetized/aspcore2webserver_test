1- add c# extensions for VSC
2- install net core (2.4.1) from https://www.microsoft.com/net/learn/get-started/windows
3- init a basic asp net app: dotnet new webapi
4- add debug assets as per popup
5- run with F5: mind VSC will open wrong address, replace with: http://localhost:5000/api/values
6- do your stuff
7- publish a self-contained app with: dotnet publish -r <RID>
where <RID> is a tag for a target platform (linux, win...) see RIDs at: https://docs.microsoft.com/en-us/dotnet/core/rid-catalog
8- publish in release: dotnet publish -r <RID> -c Release

notes:
a) if static files are enabled -app.UseStaticFiles()- but no default file is requested  -app.UseDefaultFiles()-,
templates have precedence
b) if both MCV and Razor Pages are active MCV is the default.
c) so precedence is: MCV -> Razor Pages -> static.