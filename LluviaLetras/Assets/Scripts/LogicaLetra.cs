using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaLetra : MonoBehaviour
{
     TextMesh text;
     
    void Awake()
    {
        text = GetComponent<TextMesh>();
        if (text == null) Debug.Log("La letra no tiene asociado el Text Mesh");
        char A; //variable char
        
        //Creamos un int que selecciona 1 entre 3 posibilidades de generacion     
        int bloque = Random.Range(0, 3);//Va del 0 al 3 por que no coge el ultimo valor 
        if (bloque == 0) A = (char)Random.Range(48, 58); //Numeros
        else if(bloque==1) A = (char)Random.Range(65, 91);//Mayúsculas
        else  A = (char)Random.Range(97, 123); //Minúsculas

        text.text = A.ToString();   //Transformamos el char a cadena de texto y la asignamos a la variable global letra
    }

    void Update()
    {
        //DECTA PULSACION TECLADO Y COMPRUEBA
        if (Input.inputString == text.text) Destroy(this.gameObject);
    }
}
