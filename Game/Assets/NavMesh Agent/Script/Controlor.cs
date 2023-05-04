using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controlor : MonoBehaviour
{
    public int count;
    public Transform[] point;
    public NavMeshAgent nevMeshAgent;
    

    void Start()
    {
        // "Move" : 실행할 함수의 이름
        // 1 : 몇 초 뒤에 실행할 시간
        // 5 : 몇 초 마다 실행할 시간

        InvokeRepeating("Move", 1, 5);
    }

    public void Move()
    {
        if (nevMeshAgent.velocity == Vector3.zero)
        {
            if (point.Length <= count)
                count = 0;

            // SetDestination : 이동하고자 하는 위치

            nevMeshAgent.SetDestination(point[count++].position);
        }
    }
}
