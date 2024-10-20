using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PathMover : MonoBehaviour
{
    public Transform[] pathPoints; // 路径点数组
    public float speed = 2.0f; // 移动速度
    private int currentPointIndex = 0; // 当前路径点索引
    private bool isMoving = true; // 移动状态

    void Update()
    {
        // 检查是否有路径点
        if (pathPoints.Length == 0 || !isMoving) return;

        // 移动到当前路径点
        Transform targetPoint = pathPoints[currentPointIndex];
        float step = speed * Time.deltaTime; // 计算移动步长
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);

        // 输出当前坐标和目标坐标
        Debug.Log($"Current Position: {transform.position}, Target Point: {targetPoint.position}");

        // 检查是否到达当前路径点
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            // 检查是否是最后一个路径点
            if (currentPointIndex >= pathPoints.Length - 1)
            {
                isMoving = false; // 停止移动
            }
            else
            {
                // 移动到下一个路径点
                currentPointIndex++;
            }
        }
    }
}

