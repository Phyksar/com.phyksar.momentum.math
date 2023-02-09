using UnityEngine;

namespace Momentum.Math
{
    public static class Vector2Extensions
    {
        public static Vector2 Rotate(this in Vector2 vector, float degrees)
        {
            var radians = degrees * Mathf.Deg2Rad;
            var sinRatio = Mathf.Sin(radians);
            var cosRatio = Mathf.Cos(radians);
            return new Vector2 {
                x = vector.x * cosRatio - vector.y * sinRatio,
                y = vector.x * sinRatio + vector.y * cosRatio
            };
        }
    }
}
