// VictoryBPLibrary.Build.cs - adjusted dependency layout for installed engine builds

using UnrealBuildTool;
using System.Collections.Generic;

public class VictoryBPLibrary : ModuleRules
{
    public VictoryBPLibrary(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        // Public dependencies - modules your public headers (or UHT-generated headers) need.
        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",

            // UI modules: make public if Victory's public headers or UHT-generated headers
            // include Slate/AppFramework types (SColorPicker, FReply, etc.)
            "Slate",
            "SlateCore",
            "AppFramework",   // contains SColorPicker
            "UMG"
        });

        // Private dependencies - internal modules used in .cpp files
        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "RHI",
            "ApplicationCore",
            // ... other internal modules
        });

        // Editor-only and Modeling/Geometry modules:
        if (Target.bBuildEditor)
        {
            // Editor-only modeling modules (move modeling dependencies here)
            PrivateDependencyModuleNames.AddRange(new string[]
            {
                "ModelingComponents",           // runtime modeling components (if available)
                "ModelingComponentsEditorOnly", // editor-only helpers
                "GeometryCore",
                "GeometryFramework",
                //"DynamicMesh",
                "GeometryAlgorithms",
                "MeshDescription",
                // If MeshModelingToolset is available in your engine, you can add it here:
                // "MeshModelingToolset"
            });

            // If some modeling features are exposed in public headers for editor builds only,
            // you can add them to PublicDependencyModuleNames inside this block instead.
        }

        // Dynamically loaded modules (keep empty if none)
        DynamicallyLoadedModuleNames.AddRange(new string[] { });

        // If you have plugin-local include directories, add them here (prefer relative plugin paths)
        // PublicIncludePaths.AddRange(new string[]{ "VictoryBPLibrary/Public" });
        // PrivateIncludePaths.AddRange(new string[]{ "VictoryBPLibrary/Private" });

        // Avoid any hard-coded absolute library paths like previously commented PublicAdditionalLibraries entries.
    }
}