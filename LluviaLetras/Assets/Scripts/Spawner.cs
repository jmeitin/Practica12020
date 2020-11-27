using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float minTime = 0.5f;
    public float maxTime = 1.5f;

    private BoxCollider2D col;

    //Variables para establecer el tiempo y los limites de posicion de la generacion de letras
    private float t;
    private float x;
    private bool crear = false;
    private bool wait = true;
    
    void Awake()
    {
        //Obtenemos el collider de el spawner para usar sus bounds como limite de generacion de letras 
        col = GetComponent<BoxCollider2D>();
        if (col == null) Debug.Log("no se encuentra el collider");
    }

    void Update()
    {
        //Si no se ha creado la letra obtenemos valores aleatorios -> Parta la posicion x y para el tiempo hasta su generacion 
        if (!crear && wait)
        {
            t = Random.Range(minTime, maxTime);
            x = Random.Range(col.bounds.min.x, col.bounds.max.x);

            crear = true;
        }
        //En cambio cuando  nos toca crear una letra , esperamos el tiempo obtenido previamente para hacer un invoke 
        else if (wait)
        {
            //Invoke del metodo que genera una nueva letra 
            Invoke("NewPrefab", t);
            wait = false;
        }
        
    }

    void NewPrefab()
    {
        Vector3 v = new Vector3(x, transform.position.y-2, transform.position.z);
        //Creacion de una nueva letra en la posicion dada por el vector v 
        Instantiate<GameObject>(prefab, v, Quaternion.identity);
        crear = false;
        wait = true;
    }
   
}
