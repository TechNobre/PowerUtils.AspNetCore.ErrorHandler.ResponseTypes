# PowerUtils.AspNetCore.ErrorHandler.ResponseTypes


# :warning: DEPRECATED

This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.


![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/main/assets/logo/logo_128x128.png)

***Extensions to standardize ResponseType attributes with ProblemDetails***

[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes.svg)](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/blob/main/LICENSE)


- [Support to](#support-to)
- [Dependencies](#dependencies)
- [How to use](#how-to-use)
  - [Install NuGet package](#install-nuget-package)
  - [Attributes](#attributes)
- [Contribution](#contribution)



## Support to<a name="support-to"></a>
- .NET 9.0
- .NET 8.0
- .NET 7.0
- .NET 6.0
- .NET 5.0



## Dependencies<a name="dependencies"></a>

- Microsoft.AspNetCore.Mvc.Core [NuGet](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Core/)
- PowerUtils.AspNetCore.ErrorHandler [NuGet](https://www.nuget.org/packages/PowerUtils.AspNetCore.ErrorHandler/)



## How to use<a name="how-to-use"></a>

### Install NuGet package<a name="Installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes

**Nuget**
```bash
Install-Package PowerUtils.AspNetCore.ErrorHandler.ResponseTypes
```

**.NET CLI**
```
dotnet add package PowerUtils.AspNetCore.ErrorHandler.ResponseTypes
```



### Attributes<a name="Attributes"></a>
- `Response400ProblemDetailsAttribute`
- `Response401ProblemDetailsAttribute`
- `Response403ProblemDetailsAttribute`
- `Response404ProblemDetailsAttribute`
- `Response409ProblemDetailsAttribute`
- `Response415ProblemDetailsAttribute`



## Contribution<a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/compare)
