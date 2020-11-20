using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cae : MonoBehaviour
{
    public float minVel = 1;
    public float maxVel = 3;
    private float v;

    void Awake()
    {
        v = Random.Range(minVel, maxVel + 1);
       
    }

    void Update()
    {
        transform.Translate(0, -v * Time.deltaTime, 0);
    }
}
