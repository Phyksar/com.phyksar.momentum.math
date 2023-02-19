using System;
using UnityEngine;

namespace Momentum.Math.Numerics
{
    [Serializable]
    public struct QuaternionLerp
    {
        public Quaternion previous;
        public Quaternion current;
        public float lastUpdateTime;

        public void Update(in Quaternion value)
        {
            previous = current;
            current = value;
            lastUpdateTime = Time.fixedTime;
        }

        public Quaternion Evaluate()
        {
            return Evaluate(Time.time);
        }

        public Quaternion Evaluate(float time)
        {
            return Quaternion.Slerp(previous, current, (time - lastUpdateTime) / Time.fixedDeltaTime);
        }
    }
}
