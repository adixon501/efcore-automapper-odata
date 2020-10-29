# efcore-automapper-odata

This repository is to reproduce an error occurring when trying to expand a many-to-many relationship using odata, automapper, and ef core as well as filtering a 2nd level property. Below are the nugets used in the repo at their latest version.

The app type is a Hosted Blazor web-assembly

-  .Net core
-  AutoMapper
-  AutoMapper.AspNetCore.OData.EFCore
-  AutoMapper.Extensions.ExpressionMapping
-  AutoMapper.Extensions.Microsoft.DependencyInjection
-  Microsoft.AspNetCore.Components.WebAssembly.Server
-  Microsoft.AspNetCore.OData

To run this repo, you will need the free version of SQL Server or better

Set the `EfCoreAutomapperOdata.Server` project as the startup project
