using UnrealBuildTool;

public class BluePochTarget : TargetRules
{
	public BluePochTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BluePoch");
	}
}
