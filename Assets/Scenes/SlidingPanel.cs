using UnityEngine;

public class SlidingPanel : MonoBehaviour
{
    public RectTransform panel; // ��Ҫ�ƶ������
    public Vector2 expandedPosition; // չ��ʱ��Ŀ��λ��
    public Vector2 collapsedPosition; // �ջ�ʱ��Ŀ��λ��
    private bool isExpanded = false; // �������Ƿ���չ��λ��

    // �л����λ�õķ���
    public void TogglePanel()
    {
        if (isExpanded)
        {
            // �ջص�ָ�����ջ�λ��
            panel.anchoredPosition = collapsedPosition;
        }
        else
        {
            // �ƶ���ָ����չ��λ��
            panel.anchoredPosition = expandedPosition;
        }
        isExpanded = !isExpanded; // �л�״̬
    }
}
