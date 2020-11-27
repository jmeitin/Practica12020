using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float unitPerSecs = 5;
    private float anchoMundo = 6.7f; 
    void Update()
    {
        //Obtenemos el sentido de movimiento
        float dir = Input.GetAxis("Horizontal");
        //Calculamos el espacio deltax en base al sentido y la velocidad
        float deltaX = dir * unitPerSecs * Time.deltaTime;

        //DADO que no hay Rigidbody ==> Translate
        if (transform.position.x + deltaX < anchoMundo && transform.position.x + deltaX > -anchoMundo)
            transform.Translate(deltaX, 0, 0);
      
    }
}
