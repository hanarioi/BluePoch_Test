using UnrealBuildTool;

public class BluePochClientTarget : TargetRules
{
	public BluePochClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("BluePoch");
	}
}
