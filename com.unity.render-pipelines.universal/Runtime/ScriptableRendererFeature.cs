using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
    /// <summary>
    /// You can add a <c>ScriptableRendererFeature</c> to the <c>ScriptableRenderer</c>. Use this scriptable renderer feature to inject render passes into the renderer.
    /// </summary>
    /// <seealso cref="ScriptableRenderer"/>
    /// <seealso cref="ScriptableRenderPass"/>
    [MovedFrom("UnityEngine.Rendering.LWRP")]
    public abstract class ScriptableRendererFeature : ScriptableObject
    {
        /// <summary>
        /// Initializes this feature's resources. This is called every time serialization happens.
        /// </summary>
        public abstract void Create();

        /// <summary>
        /// Injects one or multiple <c>ScriptableRenderPass</c> in the renderer.
        /// </summary>
        /// <param name="renderPasses">List of render passes to add to.</param>
        /// <param name="renderingData">Rendering state. Use this to setup render passes.</param>
        public abstract void AddRenderPasses(ScriptableRenderer renderer,
            ref RenderingData renderingData);

        void OnEnable()
        {
            Create();
        }

        void OnValidate()
        {
            Create();
        }

        public abstract void SetFeatureColorTarget(AttachmentDescriptor color, AttachmentDescriptor depth);

    }
}
