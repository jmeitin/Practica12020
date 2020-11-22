using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour
{
    private BoxCollider2D col;
    private void Awake()
    {
        col = GetComponent<BoxCollider2D>();
        if (col == null) Debug.Log("No se ha encontrado el BoxCollider2D de la pala");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Cae letra = collision.gameObject.GetComponent<Cae>();
        if (letra != null)
        {
            float xmax = col.bounds.max.x;
            float xmin = col.bounds.min.x;
            float ymax = col.bounds.max.y;
            if (collision.gameObject.transform.position.x >= xmin && collision.gameObject.transform.position.x <= xmax && collision.gameObject.transform.position.y > ymax+0.6) 
                letra.CambiaSentido();



        }
        else Debug.Log("No estamos colisionando con una letra ");
    }
}
