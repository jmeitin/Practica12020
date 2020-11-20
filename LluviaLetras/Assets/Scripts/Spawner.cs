using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float minTime = 0.5f;
    public float maxTime = 1.5f;

    private BoxCollider2D col;

    private float t;
    private float x;
    private bool crear = false;
    private bool wait = true;
    
    void Awake()
    {
        col = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (!crear && wait)
        {
            t = Random.Range(minTime, maxTime);
            x = Random.Range(col.bounds.min.x, col.bounds.max.x);

            crear = true;
        }

        else if (wait)
        {
            Crear(t);
            wait = false;
        }
        
    }

    void NewPrefab()
    {
        Vector3 v = new Vector3(x, transform.position.y, transform.position.z);
        Instantiate<GameObject>(prefab, v, Quaternion.identity);
        crear = false;
        wait = true;
    }
    void Crear(float t) //ESPERA UN RATO A LLAMAR AL METODO
    {
        Invoke("NewPrefab", t);        
    }
}
