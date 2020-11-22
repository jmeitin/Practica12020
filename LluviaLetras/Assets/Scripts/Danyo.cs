using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danyo : MonoBehaviour
{

    private int danyorecibido = 0;
    const int danyo = 10;
    private float time;
    private Camera cam;

    void Awake()
    {
        cam = Camera.main;  //Accedemos a la camara principal , y la guardamos en una variable privada 
    }
    void Start()
    {
        time = Time.time; //Guardamos el tiempo inicial
    }
    void Update() //Controlamos la recuperacion de vida a razón de un punto mas de vida por segundo 
    {

        if (danyorecibido < 100 && Time.time >= time + 1)
        {
            danyorecibido--;
            cam.backgroundColor = new Color(cam.backgroundColor.r - 0.01f, cam.backgroundColor.g - 0.01f, cam.backgroundColor.b - 0.01f);
            time = Time.time;
        }
        else if (danyorecibido == 100) Debug.Break();

    }

    private void OnTriggerEnter2D(Collider2D collision)     //Metodo que cambia el color de la camara en base a la perdida de vida 
    {
        if (collision.gameObject.GetComponent<LogicaLetra>() != null)
        {
            if (danyorecibido <= 90)
            {
                cam.backgroundColor = new Color(cam.backgroundColor.r + 0.1f, cam.backgroundColor.g + 0.1f, cam.backgroundColor.b + 0.1f);
                danyorecibido += danyo;
            }

        }
        else Debug.Log("Danyo detecto algo que no era una letra");
    }

}
