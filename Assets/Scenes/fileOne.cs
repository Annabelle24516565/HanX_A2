using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fileOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationSpeed = 10f; // ��ת�ٶ�

    // Update is called once per frame
    void Update()
    {
        // ��ͼƬΧ��Z��˳ʱ����ת
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }
}

