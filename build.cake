var target = Argument("target", "Default");
var solution = "ConsoleApp1.sln";

Task("Restore")
    .Does(() => DotNetCoreRestore(solution, new DotNetCoreRestoreSettings()));

Task("Default")
  .IsDependentOn("Restore")
  .Does(() =>
   {
     Information("Hello World!");
   });

RunTarget(target);