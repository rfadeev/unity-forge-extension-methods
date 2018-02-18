﻿using UnityEngine;

namespace UnityForge
{
    public static partial class RectTransformExtensions
    {
        public static void SetAnchoredPositionX(this RectTransform rectTransform, float value)
        {
            rectTransform.anchoredPosition = Vector2Utils.SetVectorX(rectTransform.anchoredPosition, value);
        }

        public static void SetAnchoredPositionY(this RectTransform rectTransform, float value)
        {
            rectTransform.anchoredPosition = Vector2Utils.SetVectorY(rectTransform.anchoredPosition, value);
        }

        public static void SetAnchorMaxX(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMax = Vector2Utils.SetVectorX(rectTransform.anchorMax, value);
        }

        public static void SetAnchorMaxY(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMax = Vector2Utils.SetVectorY(rectTransform.anchorMax, value);
        }

        public static void SetAnchorMinX(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMin = Vector2Utils.SetVectorX(rectTransform.anchorMin, value);
        }

        public static void SetAnchorMinY(this RectTransform rectTransform, float value)
        {
            rectTransform.anchorMin = Vector2Utils.SetVectorY(rectTransform.anchorMin, value);
        }

        public static void SetOffsetMaxX(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMax = Vector2Utils.SetVectorX(rectTransform.offsetMax, value);
        }

        public static void SetOffsetMaxY(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMax = Vector2Utils.SetVectorY(rectTransform.offsetMax, value);
        }

        public static void SetOffsetMinX(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMin = Vector2Utils.SetVectorX(rectTransform.offsetMin, value);
        }

        public static void SetOffsetMinY(this RectTransform rectTransform, float value)
        {
            rectTransform.offsetMin = Vector2Utils.SetVectorY(rectTransform.offsetMin, value);
        }

        public static void SetPivotX(this RectTransform rectTransform, float value)
        {
            rectTransform.pivot = Vector2Utils.SetVectorX(rectTransform.pivot, value);
        }

        public static void SetPivotY(this RectTransform rectTransform, float value)
        {
            rectTransform.pivot = Vector2Utils.SetVectorY(rectTransform.pivot, value);
        }

        public static void SetSizeDeltaX(this RectTransform rectTransform, float value)
        {
            rectTransform.sizeDelta = Vector2Utils.SetVectorX(rectTransform.sizeDelta, value);
        }

        public static void SetSizeDeltaY(this RectTransform rectTransform, float value)
        {
            rectTransform.sizeDelta = Vector2Utils.SetVectorY(rectTransform.sizeDelta, value);
        }
    }
}
