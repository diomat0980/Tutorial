using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardBall : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float speed = 1.0f;
    [SerializeField] Rigidbody rigidBody;
    
    void Update()
    {
        direction.z = Input.GetAxis("Vertical");
        direction.x = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidBody.AddForce
            (
                direction * speed,      // 방향과 속도
                ForceMode.Acceleration  // 힘을 주는 형태
            );

        // ForceMode.Acceleration : 질량을 무시하고 연속적인 힘을 가하는 모드
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pillar"))
        {
            var result = Vector3.Reflect
            (
                transform.position.normalized,
                collision.contacts[0].normal
            );

            rigidBody.velocity = result * Mathf.Max(speed, 0f);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Billiard Ball"))
        {
            rigidBody.AddTorque
            (
                Vector3.up * speed, // 회전 축과 속도
                ForceMode.Impulse   // 회전하는 힘의 형태
            );

            // ForceMode.Impulse : 질량을 적용한 상태로 순간적인 힘을 사용하는 힘의 형태이다.
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Pillar"))
        {
            int randomMode = Random.Range(0, 3);
            rigidBody.interpolation = (RigidbodyInterpolation)randomMode;
        }
    }
}
