using UnrealBuildTool;

public class TurorialEditor : ModuleRules
{
	public TurorialEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

    PublicDependencyModuleNames.AddRange(new string[] { "Tutorial" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

  //Only if you created the Public and Private folder paths
      PublicIncludePaths.AddRange(
          new string[]
          {
              "TutorialEditor/Public"
          });

      PrivateIncludePaths.AddRange(
          new string[]
          {
          "TutorialEditor/Private"
          });
}
