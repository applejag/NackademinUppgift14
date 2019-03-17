# NackademinUppgift14
EPiServer web app simulating a company homepage.

## NuGet tips

EPiServer's NuGet packages are a little bit tricky. First off you need to add the following to your NuGet sources:
(Can be found in Visual Studio under `Tools > NuGet Package Manager > Package Manager Settings > Package Sources`)

```
Name: EPiServer NuGet feed
Source: https://nuget.episerver.com/feed/packages.svc/
```

> _`Name` does not have to be exact._

If after cloning the repository your modules/ folder is empty (for either AlloyTraining or AlloyDemo)
then open the `Package Manager Console`, **make sure Package source is set to All** _(in the console)_ and execute the following command to reinstall the packages:

```
Update-Package -Reinstall
```

> _The Zip files in the modules folder is added during installation via script and is skipped upon regular NuGet restore._
