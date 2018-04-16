# ASP.Net-DiffMatchpatch

It is REST API for Google-DiffMatchPatch

API-
----

* URL-

	./Home/DiffMatchPatch

* Param-

   `FirstString` - `string`

   `SecondString` - `string`

   `TimeOut` - `float` (in seconds) (optional) - default (0 / infinite time)

Request Type- `POST`

Operation Code detail-

	DELETE = 0
	INSERT = 1
	EQUAL = 2

Build Command for CMD-
----------------------

	dotnet build --configuration Release --runtime ubuntu.16.04-x64

More can be found in [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build?tabs=netcore2x "Build Project").

Hosting on Linux with NGinX can be found in [here](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx?view=aspnetcore-2.1&tabs=aspnetcore2x "Deploy in Linux with NGinX").
