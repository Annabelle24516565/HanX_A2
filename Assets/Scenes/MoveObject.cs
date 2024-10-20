using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AutoMove : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.right; // 平移方向改为 X 轴正方向
    public float speed = 2.0f; // 平移速度

    void Update()
    {
        // 计算每帧的移动
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
}

