using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Destruccion de cualquier objeto que entre en el trigger de la deathzone 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<LogicaLetra>() == null)
        {
            Debug.Log("Destroyer detecto algo que no era una letra");
        }
         Destroy(collision.gameObject); 

    }
}
