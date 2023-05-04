using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        // SetFloat ("�ִϸ����� �Ķ������ �̸�", �Ӽ� ��);
        
        // vertical(Greater) ���� 0.1 ���� ũ��.
        // vertical(less) ���� -0.1 ���� �۴�

        animator.SetFloat("Vertiacl", vertical);
        animator.SetFloat("Horizontal", horizontal);
    }
}
