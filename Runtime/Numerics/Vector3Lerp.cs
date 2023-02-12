using System;
using UnityEngine;

namespace Momentum.Math.Numerics
{
    [Serializable]
    public struct Vector3Lerp
    {
        public Vector3 previous;
        public Vector3 current;
        public float lastUpdateTime;

        public void Update(in Vector3 value)
        {
            previous = current;
            current = value;
            lastUpdateTime = Time.fixedTime;
        }

        public Vector3 Evaluate()
        {
            return Evaluate(Time.time);
        }

        public Vector3 Evaluate(float time)
        {
            return Vector3.Lerp(previous, current, (time - lastUpdateTime) / Time.fixedDeltaTime);
        }
    }
}
