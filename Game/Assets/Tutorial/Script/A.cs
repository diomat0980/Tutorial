using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class A : MonoBehaviour
{
    public int data = 100;

    private void Start()
    {
        Debug.Log("Data 변수의 값 : " + data);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }

    // 물리적인 충돌을 했을 때 호출되는 이벤트 함수
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    // 물리적인 충돌이 진행 중일 때 호출되는 이벤트 함수
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    // 물리적인 충돌이 끝났을 때 호출되는 이벤트 함수
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
}