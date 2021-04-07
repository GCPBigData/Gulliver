using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cvermelho : MonoBehaviour
{

    float y = 0.2f;
    float x = 0.2f;
    float z = 0.2f;
    Vector3 nevSize;

    public GameObject _gvermelho;
    public GameObject _gfogo;
    public GameObject _pvermelho;
    public GameObject _cvermelho;
    public GameObject _pfogo;
    public GameObject _cb;
        

    public void Diminui()
    {
        transform.localScale = new Vector3(x, y, z);
        Destroy(this.gameObject);
    }

    public void Destroi()
    {

        if (gameObject.tag.Equals("cvermelho"))
        {


            //caixa vermelha gatilho
            _cvermelho = GameObject.FindGameObjectsWithTag("cvermelho")[0];
            //destroi a caixa gatilho vermelha
            //Destroy(_cvermelho);

            //paredes vermelhas
            _pvermelho = GameObject.FindGameObjectsWithTag("pvermelho")[0];
            //destroi todas paredes vermelhas
            Destroy(_pvermelho);

            //gigante vermelho 
            _gvermelho = GameObject.FindGameObjectsWithTag("gvermelho")[0];
            //destroi o gigante vermelho
            Destroy(_gvermelho);

            //gigante fogo amarelo
            _gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //ativa gigante de fogo amarelo

            //paredes fogo
            _pfogo = GameObject.FindGameObjectsWithTag("pfogo")[0];


        }

    }
}