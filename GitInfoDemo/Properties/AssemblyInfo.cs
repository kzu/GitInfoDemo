using System.Reflection;
using System.Runtime.InteropServices;
using GitInfoDemo;

[assembly: AssemblyTitle ("GitInfoDemo")]
[assembly: AssemblyProduct ("GitInfoDemo")]

[assembly: ComVisible (false)]

[assembly: AssemblyVersion (ThisAssembly.Git.BaseVersion.Major + "." + ThisAssembly.Git.BaseVersion.Minor + "." + ThisAssembly.Git.BaseVersion.Patch)]
[assembly: AssemblyFileVersion (ThisAssembly.Git.SemVer.Major + "." + ThisAssembly.Git.SemVer.Minor + "." + ThisAssembly.Git.SemVer.Patch)]
[assembly: AssemblyInformationalVersion (
	ThisAssembly.Git.SemVer.Major + "." + 
	ThisAssembly.Git.SemVer.Minor + "." + 
	ThisAssembly.Git.Commits + "-" + 
	ThisAssembly.Git.Branch + "+" + 
	ThisAssembly.Git.Commit)]
