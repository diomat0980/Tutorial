using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;


    void Update()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;

        mainCamera.fieldOfView = Mathf.Clamp
        (
            mainCamera.fieldOfView, // �����ϰ� ���� �Ӽ�
            20f,                    // �ּڰ�
            60f                     // �ִ�
        );

        mainCamera.fieldOfView += distance;
    }
}
