using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float ancho;
    public float altura;

    void Start()
    {
        Generar();
    }

    public void Generar()
    {
        GameObject baseObject = new GameObject("Base");
        baseObject.transform.position = new Vector3(0, 0, 0);

        BoxCollider2D collider = baseObject.AddComponent<BoxCollider2D>();
        collider.size = new Vector2(ancho, altura);

        SpriteRenderer renderer = baseObject.AddComponent<SpriteRenderer>();
        renderer.size = new Vector2(ancho, altura);
        renderer.color = Color.gray;

        baseObject.transform.SetParent(transform);
    }
}

