using System;

namespace UnityEngine.Rendering.HighDefinition
{
    /// <summary> The layer mask used by materials for decals. </summary>
    public struct DecalLayerMask : IEquatable<DecalLayerMask>
    {
        /// <summary>Number of layers possible.</summary>
        public const int Capacity = 8;
        /// <summary>No layers are accepted.</summary>
        public static readonly DecalLayerMask None = new DecalLayerMask(0);
        /// <summary>All layers are accepted.</summary>
        public static readonly DecalLayerMask Full = new DecalLayerMask((1 << Capacity) - 1);

        readonly int m_Value;

        public DecalLayerMask(int value) => m_Value = value;

        public static explicit operator int(in DecalLayerMask v) => v.m_Value;
        public static explicit operator DecalLayerMask(in int v) => new DecalLayerMask(v);
        public static DecalLayerMask operator&(in DecalLayerMask l, in DecalLayerMask r) => new DecalLayerMask((int)l & (int)r);
        public static DecalLayerMask operator|(in DecalLayerMask l, in DecalLayerMask r) => new DecalLayerMask((int)l | (int)r);
        public static DecalLayerMask operator^(in DecalLayerMask l, in DecalLayerMask r) => new DecalLayerMask((int)l ^ (int)r);

        public override string ToString() => $"DecalLayerMask({m_Value:x2})";

        public bool Equals(DecalLayerMask other)
        {
            return m_Value == other.m_Value;
        }

        public override bool Equals(object obj)
        {
            return obj is DecalLayerMask other && Equals(other);
        }

        public override int GetHashCode()
        {
            return m_Value;
        }

        public static bool operator ==(DecalLayerMask left, DecalLayerMask right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DecalLayerMask left, DecalLayerMask right)
        {
            return !left.Equals(right);
        }
    }
}
