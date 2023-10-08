using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using MoreMountains.Feedbacks;

public class MouseHoverUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private MMFeedbacks enterHoverFeedbacks;
    [SerializeField] private MMFeedbacks exitHoverFeedbacks;

    public void OnPointerEnter(PointerEventData eventData)
    {
        enterHoverFeedbacks.PlayFeedbacks();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!exitHoverFeedbacks) return;
        exitHoverFeedbacks.PlayFeedbacks();
    }
}
