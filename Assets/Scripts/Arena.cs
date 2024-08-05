using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    public Base limites;

    void Start()
    {
        limites = GetComponent<Base>();
        if (limites != null)
        {
            limites.Generar();
        }
    }
}

