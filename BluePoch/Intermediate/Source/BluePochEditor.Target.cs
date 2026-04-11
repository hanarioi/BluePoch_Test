using UnrealBuildTool;

public class BluePochEditorTarget : TargetRules
{
	public BluePochEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BluePoch");
	}
}
