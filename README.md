# SVG Image loading issue

Currently, on iOS, `SvgCachedImage` is not able to correctly use [IconTintColorBehavior](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/icon-tint-color-behavior) from the MAUI community Toolkit.

The image loads before the tint is applied, meaning that the user has to load the screen again (to get the cached version) in order for the tint to apply properly.
