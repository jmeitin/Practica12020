using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float unitPerSecs = 5;
    private float anchoMundo = 6.7f; 

    void Update()
    {
        float dir = Input.GetAxis("Horizontal");
        float deltaX = dir * unitPerSecs * Time.deltaTime;

        //DADO que no hay Rigidbody ==> Translate
        if (transform.position.x + deltaX < anchoMundo && transform.position.x + deltaX > -anchoMundo)
            transform.Translate(deltaX, 0, 0); 

        //ESTO NO TERMINA DE AJUSTARSE AL BORDE
    }
}
