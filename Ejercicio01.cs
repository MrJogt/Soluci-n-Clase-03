using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio01 : MonoBehaviour
{
    /*---- Busca la inconcistencia del codigo ----*/

    public float speed = 100f;
    public Rigidbody2D rb_2d; 


    void Start()
    {
        rb_2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Movimiento del jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        rb_2d.velocity = new Vector2(x * speed, y);

    }
}
