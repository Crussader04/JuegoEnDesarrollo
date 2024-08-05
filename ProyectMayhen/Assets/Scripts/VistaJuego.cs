using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistaJuego : MonoBehaviour
{
    public Arena actualArena;
    public List<Personaje> jugadores;
    public Mejora mejoras;

    void Start()
    {
        InicioJuego();
    }

    public void InicioJuego()
    {
        Debug.Log("Iniciando el juego...");
    }

    public void FinJuego()
    {
        Debug.Log("Juego terminado.");
    }
}
