using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    string acci�n = "Attack";
    int habilidad = 1;

    void EjecutarAcci�n()
    {
        switch (habilidad)
        {
            case 1:
                acci�n = "Heal"
                    Debug.Log("Me cur�");
                break;
            case 2:
                acci�n = "Attack"
                    Debug.Log("Hago da�o");
                break;
            case 3:
                acci�n = "Special Attack"
                    Debug.Log("Empiezo a girar como trompo");
                break;
         
        }
    }
}
}
