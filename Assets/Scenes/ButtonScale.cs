using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScale : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale; // ��ȡԭʼ����ֵ
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale = originalScale * 0.5f; // ����ʱ��С
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localScale = originalScale; // �ɿ�ʱ�ָ�ԭʼ��С
    }
}
