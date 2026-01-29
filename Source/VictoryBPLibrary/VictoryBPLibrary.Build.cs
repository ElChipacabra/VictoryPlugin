// Some copyright should be here...

using UnrealBuildTool;

public class VictoryBPLibrary : ModuleRules
{
	public VictoryBPLibrary(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
		
		//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
		//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
		//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
		// Rama Joy Geo 
		// (You can remove these and the MeshModelingToolset in the .uplugin 
		// if you don't need The CreateStaticMeshAssetFromDynamicMesh or GetStaticMeshVertexLocations)
		if(Target.bBuildEditor)
		{
			//CreateStaticMeshAssetFromDynamicMesh
			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"ModelingComponentsEditorOnly"
				}
			);
		} // End Editor Only
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				//GetStaticMeshVertexLocations
				"Core",
				"MeshDescription",
				
				//CreateStaticMeshAssetFromDynamicMesh
				"GeometryFramework",
				"ModelingComponents",
				            // Geometry / modeling runtime modules required to resolve FDynamicMesh3 and friends
            "GeometryCore",
            "DynamicMesh",        // module exposed by GeometryProcessing plugin
            "ModelingComponents", // runtime part exposed by MeshModelingToolset plugin
            "GeometryAlgorithms"  // optional if you use it (from GeometryProcessing)
			}
			);
		//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
		//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
		//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"InputCore",
				"RHI",
				"Slate",
				"SlateCore",
				"ApplicationCore",
				"AppFramework",			//For Color Picker! ♥ Rama
				"UMG", "Slate", "SlateCore",
			
			}
			);

        //PublicAdditionalLibraries.Add("C:/Program Files/Epic Games/UE_5.7/Engine/Intermediate/Build/Win64/x64/UnrealEditor/Development/GeometryCore/UnrealEditor-GeometryCore.lib");

        DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
