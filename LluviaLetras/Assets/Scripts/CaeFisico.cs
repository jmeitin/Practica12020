using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaeFisico : MonoBehaviour
{
    public float minVel = 1;
    public float maxVel = 3;
    private Rigidbody2D rb;
    private float v;
    void Awake()
    {
        //Obtenemos un valor aleatorio entre las dos variables de velocidad 
        v = Random.Range(minVel, maxVel + 1);
        //Cacheamos el cuerpo rigido de nuestra letra fisica
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) Debug.Log("Letra Fisia no tiene un RigidBody2D");
    }
    void FixedUpdate()
    {
        //Modificamos la velocidad de el cuerpo rigido de nuestra letra a partir de a variable v creada 
        rb.velocity= new Vector2(0, -v);
    }
}
