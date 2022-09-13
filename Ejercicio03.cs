using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    /*---- Ordena el Códgo  ----*/

        public float speed;
        public float speed2;
        public float Z;
        public float movimiento_x;
        private Rigidbody2D fisicas;
        bool esta_Saltando;

    private void Start()
        {
            fisicas = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            movimiento_x = Input.GetAxis("Horizontal");
            Z += Time.deltaTime * 10;
            Movimiento();
        }

        public void Movimiento()
        {
            //Movimiento del jugador - Der
            if (Input.GetKeyDown(KeyCode.D))
            {
                
                fisicas.velocity = new Vector2(movimiento_x * speed, 0);
            }
            //Movimiento del jugador - Izquierda
            if (Input.GetKeyDown(KeyCode.A))
            {
                
                fisicas.velocity = new Vector2(movimiento_x * speed, 0);
            }
            //Rotacion del jugador
            if (Input.GetKeyDown(KeyCode.R))
            {
                
                transform.rotation = Quaternion.Euler(0, 0, Z);

            }
            //Salto del jugador 
            if (Input.GetButton("Jump") && !esta_Saltando)
            {
                //Le aplico la fuerza de salto
                rb2d.AddForce(Vector2.up * speed2);
                Debug.Log("Estoy saltando Wiiii");
                //Digo que está saltando (para que no pueda volver a saltar)
                esta_Saltando = true;
            }
    }


}
