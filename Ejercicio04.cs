using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio04 : MonoBehaviour
{
    /*---- Busca otra alternativa ----*/

    /*Dato:Queremos saber si existe el nombre de un enemigo dentro de una lista.
      Podriamos mejorarlo usando algun método de Linq.
    */

    public List<string> enemigos = new List<string>() { "Orco","Araña","Golem","Goblin"};
    string enemigo = "Araña";



    public void EncontrandoEnemigo()
    {
        
        for (int i = 0; i < enemigos.Length; i++)
        {
            enemigos.All(e => enemigo);
        }

        return "No se encontró";


    }
}
