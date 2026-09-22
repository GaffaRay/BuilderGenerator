[![GitHub](https://img.shields.io/github/license/melgrubb/buildergenerator)](https://opensource.org/licenses/MIT)

# Builder Generator - Parameterized Constructor #

This is a fork of the libarby at [MelGrubb/BuilderGenerator](https://github.com/MelGrubb/BuilderGenerator/). I implemented logic to use the BuilderPattern for classes with parameterized constructors. Unfortunately these changes caused breaking changes, so I decided to fork the code an create a separate nuget-package.  

## Overview ##

This is a .Net Source Generator designed to add "Builders" to your projects. [Builders](https://en.wikipedia.org/wiki/Builder_pattern) are an object creation pattern, similar to the [Object Mother](https://martinfowler.com/bliki/ObjectMother.html) pattern. Object Mothers and Builders are most commonly used to create objects for testing, but they can be used anywhere you want "canned" objects.

For more complete documentation, please see the [documentation site](https://melgrubb.github.io/BuilderGenerator/) or the raw [documentation source](https://github.com/MelGrubb/BuilderGenerator/blob/main/docs/index.md).

## Installation ##

BuilderGenerator is installed as an analyzer via NuGet package (https://www.nuget.org/packages/BuilderGenerator/). You can find it through the "Manage NuGet Packages" dialog in Visual Studio, or from the command line.

```ps
Install-Package BuilderGenerator.ParameterizedConstructor
```

## Usage ##

After installation, create a partial class to define your builder in. Decorate it with the ```BuilderFor``` attribute, specifying the type of class that the builder is meant to build (e.g. ```[BuilderFor(typeof(Foo))]```. Define any factory and helper methods in this partial class. Meanwhile, another partial class definition will be auto-generated which contains all the "boring" parts such as the backing fields and "with" methods.

## Version History ##
- v1.0.0
  - Classes with parameterized constructors can be used by the Builders.
  - New-Method added to the Builder so Build() can be called multiple times to create multiple instances of the target class.

## Roadmap ##

- Read-only collection support in default templates
- Attribute-less generation of partial classes
- Completed documentation
- Unit tests for generation components

## Attributions ##

The BuilderGenerator logo includes [tools](https://thenounproject.com/term/tools/11192) by John Caserta from the Noun Project.
