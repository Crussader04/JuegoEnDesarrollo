using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje
{
    protected override void Update()
    {
        base.Update();
        Movimiento();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }

    protected override void Movimiento()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * Time.deltaTime * 5f);
    }

    protected override void Saltar()
    {
        Debug.Log("Saltar");
    }

    protected override void Disparar()
    {
        if (armaActual != null)
        {
            armaActual.Disparar(Vector2.right);
        }
    }
}

