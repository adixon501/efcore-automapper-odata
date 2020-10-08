# efcore-automapper-odata

This repository is to reproduce an error occurring when trying to expand a many-to-many relationship using odata, automapper, and ef core. Below are the versions used in the repo.

The app type is a Hosted Blazor web-assembly

-  .Net core Version="3.1"
-  AutoMapper Version="10.0.0"
-  AutoMapper.AspNetCore.OData.EFCore Version="2.0.1"
-  AutoMapper.Extensions.ExpressionMapping Version="4.0.1"
-  AutoMapper.Extensions.Microsoft.DependencyInjection Version="8.0.1"
-  Microsoft.AspNetCore.Components.WebAssembly.Server Version="3.2.1"
-  Microsoft.AspNetCore.OData Version="7.5.0"

To run this repo, you will need the free version of SQL Server or better

Set the `EfCoreAutomapperOdata.Server` project as the startup project and navigate to the Courses page (https://localhost:44374/courses) and click on either course. This will throw the following error:

`
    System.InvalidOperationException: No generic method 'Include' on type 'Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions' is compatible with the supplied type arguments and arguments. No type arguments should be provided if the method is non-generic. 
   at System.Linq.Expressions.Expression.FindMethod(Type type, String methodName, Type[] typeArgs, Expression[] args, BindingFlags flags)...
`
