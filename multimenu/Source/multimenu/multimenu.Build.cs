// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class multimenu : ModuleRules
{
	public multimenu(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",

            "OnlineSubsystemSteam",
            "OnlineSubsystem"
        });

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"multimenu",
			"multimenu/Variant_Platforming",
			"multimenu/Variant_Platforming/Animation",
			"multimenu/Variant_Combat",
			"multimenu/Variant_Combat/AI",
			"multimenu/Variant_Combat/Animation",
			"multimenu/Variant_Combat/Gameplay",
			"multimenu/Variant_Combat/Interfaces",
			"multimenu/Variant_Combat/UI",
			"multimenu/Variant_SideScrolling",
			"multimenu/Variant_SideScrolling/AI",
			"multimenu/Variant_SideScrolling/Gameplay",
			"multimenu/Variant_SideScrolling/Interfaces",
			"multimenu/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
