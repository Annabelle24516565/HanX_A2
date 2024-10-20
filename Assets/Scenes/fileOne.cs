using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fileOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationSpeed = 10f; // 旋转速度

    // Update is called once per frame
    void Update()
    {
        // 让图片围绕Z轴顺时针旋转
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }
}

