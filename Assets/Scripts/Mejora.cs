using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mejora : MonoBehaviour
{
    public string tipo;
    public float duracion;

    public void Activar(Personaje personaje)
    {
        Debug.Log("Activando mejora: " + tipo);
    }
}
