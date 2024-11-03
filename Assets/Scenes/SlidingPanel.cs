using UnityEngine;

public class SlidingPanel : MonoBehaviour
{
    public RectTransform panel; // 需要移动的面板
    public Vector2 expandedPosition; // 展开时的目标位置
    public Vector2 collapsedPosition; // 收回时的目标位置
    private bool isExpanded = false; // 标记面板是否在展开位置

    // 切换面板位置的方法
    public void TogglePanel()
    {
        if (isExpanded)
        {
            // 收回到指定的收回位置
            panel.anchoredPosition = collapsedPosition;
        }
        else
        {
            // 移动到指定的展开位置
            panel.anchoredPosition = expandedPosition;
        }
        isExpanded = !isExpanded; // 切换状态
    }
}
