using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    /*---- Mejorá el código  ----*/

    //Dato:no se que es,pero siento que algo no esta bien.


    int fuerza = 100;
    int agilidad = 50;
    int fuerzaMax;
    int agilidadMax;

    private void Start()
    {
        fuerzaMax = (fuerza * 2) / 5;
        agilidadMax = agilidad / 2;
    }
    
    private void Update()
    {

    }

    private void EjecutarAtaqueEspecial()
    {
        if (fuerzaMax > -1 && agilidadMax > 20))

        {
            Debug.Log("Ataque especial ejecutado");
        }
    }
}
