# Changelog




## [1.1.0] - 2022-05-29
[Full Changelog](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/compare/v1.0.0...v1.1.0)


### New Features

- Added `Response413ProblemDetailsAttribute`;




## [1.0.0] - 2022-03-15

- Kickoff;
- Moved the attributes from [PowerUtils.AspNetCore.WebAPI](https://github.com/TechNobre/PowerUtils.AspNetCore.WebAPI) project to this one so it can be used individually;


### Breaking Changes

- namespace `PowerUtils.AspNetCore.WebAPI.Attributes.ResponseTypes` named to `PowerUtils.AspNetCore.Attributes.ResponseTypes`;
- `Response400BadRequest` named to `Response400ProblemDetailsAttribute`;
- `Response401Unauthorized` named to `Response401ProblemDetailsAttribute`;
- `Response403Forbidden` named to `Response403ProblemDetailsAttribute`;
- `Response404NotFound` named to `Response404ProblemDetailsAttribute`;
- `Response409Conflict` named to `Response409ProblemDetailsAttribute`;
- `Response415UnsupportedMediaType` named to `Response415ProblemDetailsAttribute`;