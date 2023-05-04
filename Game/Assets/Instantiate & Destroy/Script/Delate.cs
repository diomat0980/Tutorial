using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delate : MonoBehaviour
{
    int random;

    void Start()
    {
        random = Random.Range(1, 5);
        Destroy(gameObject, random);
    }
}
