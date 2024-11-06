using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Framework;

[assembly: AssemblyTitle("SeleniumCSharpTutorials")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("nunit.tests")]
[assembly: AssemblyCopyright("Copyright © 2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Ustawienie COM visibility na false, jeśli nie potrzebujesz udostępniać typów w tym zestawie dla COM
[assembly: ComVisible(false)]

// Wersja zestawu (możesz zmienić numery wersji zgodnie z potrzebami)
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//To define [Test] attributes
[assembly: Parallelizable(ParallelScope.Children)]

//Number of browsers
[assembly: LevelOfParallelism(4)]