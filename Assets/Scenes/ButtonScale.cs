using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScale : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale; // 获取原始缩放值
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale = originalScale * 0.5f; // 按下时缩小
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localScale = originalScale; // 松开时恢复原始大小
    }
}
