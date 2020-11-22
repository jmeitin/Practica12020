using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaLetra : MonoBehaviour
{
    private TextMesh text;

    void Awake()
    {
        text = GetComponent<TextMesh>();
        if (text == null) Debug.Log("La letra no tiene asociado el Text Mesh");
        char A; //variable char                                 
                // (65, 90) son mayusculas, para minusculas (97,122)
        A = (char)Random.Range(65, 90); //Los caracteres de las letras en ASCI se encuentran entre (65, 90) para mayusculas y (97,122) minusculas
                                      //Randomizamos uno de los dos intervalos para obtener nuestro Char

        text.text = A.ToString();   //Transformamos el char a cadena de texto y la asignamos a la variable global letra
    }

    void Update()
    {
        //DECTA PULSACION TECLADO Y COMPRUEBA
        if (Input.inputString == text.text) Destroy(this.gameObject);
    }
}
