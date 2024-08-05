using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public float daño;
    public string alcance;
    public int municion;
    public float recarga;
    public GameObject proyectilPrefab;
    public Transform puntoDisparo;
    public float fuerzaEmpujeProyectil;

    private bool puedeDisparar = true;

    void Start()
    {
        municion = 10;
    }

    public void Disparar(Vector2 direccion)
    {
        if (puedeDisparar && municion > 0)
        {
            GameObject proyectil = Instantiate(proyectilPrefab, puntoDisparo.position, Quaternion.identity);
            Proyectil scriptProyectil = proyectil.GetComponent<Proyectil>();
            scriptProyectil.direccion = direccion;
            scriptProyectil.fuerzaEmpuje = fuerzaEmpujeProyectil;

            municion--;
            StartCoroutine(Recargar());
        }
        else if (municion <= 0)
        {
            Debug.Log("Sin munición");
        }
    }

    private IEnumerator Recargar()
    {
        puedeDisparar = false;
        Debug.Log("Recargando...");
        yield return new WaitForSeconds(recarga);
        puedeDisparar = true;
        Debug.Log("Listo para disparar");
    }
}

