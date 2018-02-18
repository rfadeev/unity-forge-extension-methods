using UnityEngine;

namespace UnityForge
{
    public static class Vector3Utils
    {
        public static Vector3 SetVectorX(Vector3 vector, float value)
        {
            return new Vector3(value, vector.y, vector.z);
        }

        public static Vector3 SetVectorY(Vector3 vector, float value)
        {
            return new Vector3(vector.x, value, vector.z);
        }

        public static Vector3 SetVectorZ(Vector3 vector, float value)
        {
            return new Vector3(vector.x, vector.y, value);
        }
    }
}
