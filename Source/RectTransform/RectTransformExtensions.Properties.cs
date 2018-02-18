using UnityEngine;

namespace UnityForge
{
    public static partial class RectTransformExtensions
    {
        public static void SetAnchoredPositionX(this RectTransform rectTransform, float value)
        {
            rectTransform.anchoredPosition = SetVectorX(rectTransform.anchoredPosition, value);
        }

        public static void SetAnchoredPositionY(this RectTransform rectTransform, float value)
        {
            rectTransform.anchoredPosition = SetVectorY(rectTransform.anchoredPosition, value);
        }

        public static void SetAnchorMaxX(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMax = SetVectorX(rectTransform.anchorMax, value);
        }

        public static void SetAnchorMaxY(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMax = SetVectorY(rectTransform.anchorMax, value);
        }

        public static void SetAnchorMinX(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMin = SetVectorX(rectTransform.anchorMin, value);
        }

        public static void SetAnchorMinY(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMin = SetVectorY(rectTransform.anchorMin, value);
        }

        public static void SetOffsetMaxX(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMax = SetVectorX(rectTransform.offsetMax, value);
        }

        public static void SetOffsetMaxY(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMax = SetVectorY(rectTransform.offsetMax, value);
        }

        public static void SetOffsetMinX(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMin = SetVectorX(rectTransform.offsetMin, value);
        }

        public static void SetOffsetMinY(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMin = SetVectorY(rectTransform.offsetMin, value);
        }

        public static void SetPivotX(this RectTransform rectTransform, float value)
        {
            rectTransform.pivot = SetVectorX(rectTransform.pivot, value);
        }

        public static void SetPivotY(this RectTransform rectTransform, float value)
        {
            rectTransform.pivot = SetVectorY(rectTransform.pivot, value);
        }

        public static void SetSizeDeltaX(this RectTransform rectTransform, float value)
        {
            rectTransform.sizeDelta = SetVectorX(rectTransform.sizeDelta, value);
        }

        public static void SetSizeDeltaY(this RectTransform rectTransform, float value)
        {
            rectTransform.sizeDelta = SetVectorY(rectTransform.sizeDelta, value);
        }

        private static Vector2 SetVectorX(Vector2 vector, float value)
        {
            return new Vector2(value, vector.y);
        }

        private static Vector2 SetVectorY(Vector2 vector, float value)
        {
            return new Vector2(vector.x, value);
        }
    }
}
