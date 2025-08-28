// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TP_MechanicsSandboxEditorTarget : TargetRules
{
	public TP_MechanicsSandboxEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "TP_MechanicsSandbox" } );
	}
}
