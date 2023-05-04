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
        // "Move" : ������ �Լ��� �̸�
        // 1 : �� �� �ڿ� ������ �ð�
        // 5 : �� �� ���� ������ �ð�

        InvokeRepeating("Move", 1, 5);
    }

    public void Move()
    {
        if (nevMeshAgent.velocity == Vector3.zero)
        {
            if (point.Length <= count)
                count = 0;

            // SetDestination : �̵��ϰ��� �ϴ� ��ġ

            nevMeshAgent.SetDestination(point[count++].position);
        }
    }
}
