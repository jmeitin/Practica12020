using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danyo : MonoBehaviour
{
    private int vida = 100;
    const int danyo = 10;

    private Camera cam;

    void Awake ()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if (vida < 100)
        {
            vida++;
            cam.backgroundColor = new Color(cam.backgroundColor.r - 0.01f, cam.backgroundColor.g - 0.01f, cam.backgroundColor.b - 0.01f);
        }
        //else Debug.Break(); //necesario?

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<LogicaLetra>() != null)
        {
            if (vida >= 10)
            {
                cam.backgroundColor = new Color(cam.backgroundColor.r + 0.1f, cam.backgroundColor.g + 0.1f, cam.backgroundColor.b + 0.1f);
                vida -= 10;
            }

        }
        else Debug.Log("Danyo detecto algo que no era una letra");
    }

}
