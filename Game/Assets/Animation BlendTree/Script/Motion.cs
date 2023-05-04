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

        // SetFloat ("애니메이터 파라미터의 이름", 속성 값);
        
        // vertical(Greater) 값이 0.1 보다 크다.
        // vertical(less) 값이 -0.1 보다 작다

        animator.SetFloat("Vertiacl", vertical);
        animator.SetFloat("Horizontal", horizontal);
    }
}
