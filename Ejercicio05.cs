using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    string acción = "Attack";
    int habilidad = 1;

    void EjecutarAcción()
    {
        switch (habilidad)
        {
            case 1:
                acción = "Heal"
                    Debug.Log("Me curé");
                break;
            case 2:
                acción = "Attack"
                    Debug.Log("Hago daño");
                break;
            case 3:
                acción = "Special Attack"
                    Debug.Log("Empiezo a girar como trompo");
                break;
         
        }
    }
}
}
