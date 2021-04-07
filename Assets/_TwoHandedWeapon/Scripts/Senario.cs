using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senario : MonoBehaviour
{
    float y = 0.5f;
    float x = 0.5f;
    float z = 0.5f;
    Vector3 nevSize;

    public void HoverOver()
    {

        transform.localScale = new Vector3(x, y, z);

    }

        public void HoverEnd()
        {

               Destroy(this.gameObject);

        }
}
