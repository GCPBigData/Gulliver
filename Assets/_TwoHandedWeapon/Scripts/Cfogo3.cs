using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cfogo3 : MonoBehaviour
{
    float y = 0.3f;
    float x = 0.3f;
    float z = 0.3f;
    Vector3 nevSize;

    public void Diminui()
    {
        transform.localScale = new Vector3(x, y, z);
    }

    public void Destroi()
    {
        Destroy(this.gameObject);
    }
}
