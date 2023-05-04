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
            mainCamera.fieldOfView, // 제한하고 싶은 속성
            20f,                    // 최솟값
            60f                     // 최댓값
        );

        mainCamera.fieldOfView += distance;
    }
}
