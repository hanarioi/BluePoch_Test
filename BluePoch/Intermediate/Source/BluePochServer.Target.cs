using UnrealBuildTool;

public class BluePochServerTarget : TargetRules
{
	public BluePochServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BluePoch");
	}
}
