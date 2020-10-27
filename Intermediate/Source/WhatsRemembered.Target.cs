using UnrealBuildTool;

public class WhatsRememberedTarget : TargetRules
{
	public WhatsRememberedTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("WhatsRemembered");
	}
}
