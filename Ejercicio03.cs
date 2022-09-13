using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    /*---- Ordena el Códgo  ----*/

        public float velocidad = 50f;
        public float movimientoX;
        public Rigidbody2D fisicas;
        bool estaSaltando = false;

    private void Start()
        {
            fisicas = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            movimientoX = Input.GetAxis("Horizontal");
            Movimiento();
        }

        private void Movimiento()
        {
            //Movimiento del jugador - Der
            if (Input.GetKeyDown(KeyCode.D))
            {
                
                fisicas.velocity = new Vector2(movimientoX * velocidad, 0);
            }
            //Movimiento del jugador - Izquierda
            if (Input.GetKeyDown(KeyCode.A))
            {
                
                fisicas.velocity = new Vector2(movimientoX * velocidad, 0);
            }

            //Salto del jugador 
            if (Input.GetKeyDown(KeyCode.W) && estaSaltando = false)
            {
                //Le aplico la fuerza de salto
                rb2d.AddForce(Vector2.up * velocidad);
                //Digo que está saltando (para que no pueda volver a saltar)
                estaSaltando = true;
            }
    }


}
