using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choca : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {

        Cae letra = collision.gameObject.GetComponent<Cae>();
        //Si la letra no es nula y esta ascendiendo por que ha rebotado con la pala , la destruimos al llegar al spawn
        if (letra != null && letra.Ascendente())
        {
            Destroy(letra.gameObject);

        }
        else Debug.Log("No estamos colisionando con una letra// La letra colisionada no lleva un sentido ascendente");
    }




}
