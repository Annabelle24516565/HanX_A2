using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AutoMove : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.right; // ƽ�Ʒ����Ϊ X ��������
    public float speed = 2.0f; // ƽ���ٶ�

    void Update()
    {
        // ����ÿ֡���ƶ�
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
}

