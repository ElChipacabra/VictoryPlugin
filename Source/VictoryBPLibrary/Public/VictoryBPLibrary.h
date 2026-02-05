// Copyright Epic Games, Inc. All Rights Reserved.

// VictoryBPFunctionLibrary.h (top)
#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"

//#include "VictoryBPFunctionLibrary.generated.h"

#include "Modules/ModuleManager.h"

class FVictoryBPLibraryModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
