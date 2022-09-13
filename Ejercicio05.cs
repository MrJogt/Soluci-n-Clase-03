using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    string acción = "Ataque";
    int habilidad = 1;

    public void EjecutarAcción()
    {
        switch (habilidad)
        {
            case 1:
                acción = "Curación"
                    Debug.Log("Me curé");
                break;
            case 2:
                acción = "Ataque"
                    Debug.Log("Hago daño");
                break;
            case 3:
                acción = "Ataque Especial"
                    Debug.Log("Empiezo a girar como trompo");
                break;
         
        }
    }
}
}
