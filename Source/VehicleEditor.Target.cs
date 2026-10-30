using UnrealBuildTool;

public class VehicleEditorTarget : TargetRules
{
	public VehicleEditorTarget(TargetInfo target) : base(target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("Vehicle");
	}
}