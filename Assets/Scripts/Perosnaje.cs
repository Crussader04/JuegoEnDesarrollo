using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float daño;
    public string nombre;
    public bool jugable;
    public Ubicacion posicion;
    public Arma armaActual;

    protected Rigidbody2D rb;

    protected virtual void Start()
    {
        daño = 10f;
        nombre = "Jugador1";
        jugable = true;
        posicion = new Ubicacion() { ejeX = 0, ejeY = 0 };
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Update()
    {
        if (HaSalidoDeLaArena())
        {
            EliminarPersonaje();
        }
    }

    protected virtual void Movimiento() { }

    protected virtual void Saltar() { }

    protected virtual void Disparar() { }

    protected bool HaSalidoDeLaArena()
    {
        return transform.position.y < -10;
    }

    protected void EliminarPersonaje()
    {
        Debug.Log(nombre + " ha sido eliminado.");
        Destroy(gameObject);
    }

    public void Recoger(Mejora item)
    {
        item.Activar(this);
    }
}
