using UnityEngine;

namespace Momentum.Math
{
    public static class FloatExtensions
    {
        public static float NormalizeBetween(this float value, float min, float max)
        {
            var range = max - min;
            var normalized = ((value - min) % range) + min;
            if (normalized < min) {
                normalized += range;
            }
            return normalized;
        }

        public static float NormalizeRadians(this float angleInRadians)
        {
            return angleInRadians.NormalizeBetween(-Mathf.PI, Mathf.PI);
        }

        public static float NormalizeDegrees(this float angleInDegrees)
        {
            return angleInDegrees.NormalizeBetween(-180.0f, 180.0f);
        }
    }
}
