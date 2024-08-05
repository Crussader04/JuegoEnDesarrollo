using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Personaje
{
    private Transform jugadorTransform;

    protected override void Start()
    {
        base.Start();
        jugadorTransform = GameObject.FindWithTag("Jugador").transform;
    }

    protected override void Update()
    {
        base.Update();
        Movimiento();
        if (PuedeDisparar())
        {
            Disparar();
        }
    }

    protected override void Movimiento()
    {
        if (jugadorTransform != null)
        {
            Vector2 direccion = (jugadorTransform.position - transform.position).normalized;
            transform.Translate(direccion * Time.deltaTime * 2f);
        }
    }

    protected override void Disparar()
    {
        if (armaActual != null)
        {
            Vector2 direccionDisparo = (jugadorTransform.position - transform.position).normalized;
            armaActual.Disparar(direccionDisparo);
        }
    }

    private bool PuedeDisparar()
    {
        float distancia = Vector2.Distance(transform.position, jugadorTransform.position);
        return distancia < 10f;
    }
}

