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
                direction * speed,      // ����� �ӵ�
                ForceMode.Acceleration  // ���� �ִ� ����
            );

        // ForceMode.Acceleration : ������ �����ϰ� �������� ���� ���ϴ� ���
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
                Vector3.up * speed, // ȸ�� ��� �ӵ�
                ForceMode.Impulse   // ȸ���ϴ� ���� ����
            );

            // ForceMode.Impulse : ������ ������ ���·� �������� ���� ����ϴ� ���� �����̴�.
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
