﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph
{
    [GenerationAPI]
    internal interface ITargetImplementation
    {
        Type targetType { get; }
        string displayName { get; }
        string passTemplatePath { get; }
        string sharedTemplateDirectory { get; }

        void SetupTarget(ref TargetSetupContext context);
        void SetActiveBlocks(ref List<BlockFieldDescriptor> activeBlocks);
        ConditionalField[] GetConditionalFields(PassDescriptor pass, List<BlockFieldDescriptor> blocks);
        VisualElement GetSettings(Action onChange);
    }

    [GenerationAPI]
    internal interface ITargetHasMetadata
    {
        string metadataIdentifier { get; }
        ScriptableObject GetMetadataObject();
    }
}
