// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DlgExample : ModuleRules
{
	public DlgExample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {"AIModule", "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

        // Plugins
        PrivateDependencyModuleNames.AddRange(new string[] { "DlgSystem" });
    }
}
