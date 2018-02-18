using UnityEngine;

namespace UnityForge
{
    public static class Vector2Utils
    {
        public static Vector2 SetVectorX(Vector2 vector, float value)
        {
            return new Vector2(value, vector.y);
        }

        public static Vector2 SetVectorY(Vector2 vector, float value)
        {
            return new Vector2(vector.x, value);
        }
    }
}
