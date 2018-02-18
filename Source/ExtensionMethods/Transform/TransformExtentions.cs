using UnityEngine;

namespace UnityForge
{
    public static class TransformExtentions
    {
        /// <summary>
        /// Rotates the transform so the forward vector points from target's current position.
        /// </summary>
        /// <param name="target">Object to point away from.</param>
        public static void LookFrom(this Transform transform, Transform target)
        {
            transform.LookFrom(target.position);
        }

        /// <summary>
        /// Rotates the transform so the forward vector points from target's current position.
        /// </summary>
        /// <param name="target">Object to point away from.</param>
        /// <param name="worldUp">Vector specifying the upward direction.</param>
        public static void LookFrom(this Transform trans, Transform target, Vector3 worldUp)
        {
            trans.LookFrom(target.position, worldUp);
        }

        /// <summary>
        /// Rotates the transform so the forward vector points from worldPosition.
        /// </summary>
        /// <param name="worldPosition">Point to look at.</param>
        public static void LookFrom(this Transform trans, Vector3 worldPosition)
        {
            trans.rotation = Quaternion.LookRotation(trans.position - worldPosition);
        }

        /// <summary>
        /// Rotates the transform so the forward vector points from worldPosition.
        /// </summary>
        /// <param name="worldPosition">Point to look at.</param>
        /// <param name="worldUp">Vector specifying the upward direction.</param>
        public static void LookFrom(this Transform trans, Vector3 worldPosition, Vector3 worldUp)
        {
            trans.rotation = Quaternion.LookRotation(trans.position - worldPosition, worldUp);
        }
    }
}
