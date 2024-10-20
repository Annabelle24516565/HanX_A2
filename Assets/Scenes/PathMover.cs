using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PathMover : MonoBehaviour
{
    public Transform[] pathPoints; // ·��������
    public float speed = 2.0f; // �ƶ��ٶ�
    private int currentPointIndex = 0; // ��ǰ·��������
    private bool isMoving = true; // �ƶ�״̬

    void Update()
    {
        // ����Ƿ���·����
        if (pathPoints.Length == 0 || !isMoving) return;

        // �ƶ�����ǰ·����
        Transform targetPoint = pathPoints[currentPointIndex];
        float step = speed * Time.deltaTime; // �����ƶ�����
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);

        // �����ǰ�����Ŀ������
        Debug.Log($"Current Position: {transform.position}, Target Point: {targetPoint.position}");

        // ����Ƿ񵽴ﵱǰ·����
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            // ����Ƿ������һ��·����
            if (currentPointIndex >= pathPoints.Length - 1)
            {
                isMoving = false; // ֹͣ�ƶ�
            }
            else
            {
                // �ƶ�����һ��·����
                currentPointIndex++;
            }
        }
    }
}

