using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    public float fuerzaEmpuje;

    void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Personaje personaje = collision.gameObject.GetComponent<Personaje>();
        if (personaje != null)
        {
            Rigidbody2D rbPersonaje = personaje.GetComponent<Rigidbody2D>();
            if (rbPersonaje != null)
            {
                rbPersonaje.AddForce(direccion * fuerzaEmpuje, ForceMode2D.Impulse);
            }
        }
        Destroy(gameObject);
    }
}

