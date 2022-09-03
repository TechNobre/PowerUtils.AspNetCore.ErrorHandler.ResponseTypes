# [2.0.0](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/compare/v1.1.0...v2.0.0) (2022-09-03)


### Build System

* **nuget:** Update dependencies ([c8513b1](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/commit/c8513b16d13a8ccc32a1276380896f95ccdb09fc))


### Features

* Add support to debug in runtime `Microsoft.SourceLink.GitHub` ([5ca159b](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/commit/5ca159bd99a6b3fe9c89afe0f734db84ebb5edf5))


### BREAKING CHANGES

* **nuget:** Removed support for `.NET 3.1`

# [1.1.0](https://github.com/TechNobre/PowerUtils.AspNetCore.ErrorHandler.ResponseTypes/compare/v1.0.0...v1.1.0) (2022-05-29)


### New Features

- Added `Response413ProblemDetailsAttribute`;




# 1.0.0 (2022-03-15)

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
