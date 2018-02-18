using UnityEngine;

namespace UnityForge
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Set the layer for game object and all its childs recursively.
        /// </summary>
        /// <param name="layer">The layer for game objects.</param>
        public static void SetLayerRecursively(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;
            foreach (Transform child in gameObject.transform)
            {
                child.gameObject.SetLayerRecursively(layer);
            }
        }

        /// <summary>
        /// Set the tag for game object and all its childs recursively.
        /// </summary>
        /// <param name="tag">The tag for game objects.</param>
        public static void SetTagRecursively(this GameObject gameObject, string tag)
        {
            gameObject.tag = tag;
            foreach (Transform child in gameObject.transform)
            {
                child.gameObject.SetTagRecursively(tag);
            }
        }
    }
}
