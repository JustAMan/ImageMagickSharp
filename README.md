ImageMagickSharp
================

This is a managed wrapper for ImageMagick that is designed for use with Mono. 

Documentation to come, for now see the unit test project for example usage.


## Available on Nuget ##

https://www.nuget.org/packages/ImageMagickSharp


## Usage

This is purely a managed wrapper for ImageMagick and does not include any native assemblies. It will be up to you to provide the native assemblies for the target operating system.

If your application is embedding ImageMagick, you'll need to call Wand.SetMagickCoderModulePath to set the path to the delegate iibraries. If you're utilizing the installed version this won't be necessary.
