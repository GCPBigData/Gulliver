using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicia : MonoBehaviour
{
    float y = 0.5f;
    float x = 0.5f;
    float z = 0.5f;
    Vector3 nevSize;

    public GameObject cubo;

    public void Diminui()
    {
        transform.localScale = new Vector3(x, y, z);

    }

    public void Destroi()
    {
        if (gameObject.tag.Equals("cubea"))
        {
            cubo = GameObject.FindGameObjectsWithTag("cubeb")[0];
            Destroy(cubo);
            transform.localScale = new Vector3(x, y, z);


        }
    }
}
