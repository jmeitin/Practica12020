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
        //Obtenemos un valor aleatorio entre las dos variables de velocidad 
        v = Random.Range(minVel, maxVel + 1);      
    }
    void Update()
    {
        //Modificamos el transform de la letra en el eje y 
        transform.Translate(0, -v * Time.deltaTime, 0);
    }


    //Metodos de la escena MyGame   
    public void CambiaSentido()
    {
        //Cambiamos el sentido de el eje y de la letra 
        v = -v; 
    }
    public bool Ascendente()
    {  
        return v < 0;
    }
}
