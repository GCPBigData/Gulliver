using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cfogo : MonoBehaviour
{
    float y = 0.3f;
    float x = 0.3f;
    float z = 0.3f;

    float y1 = 1.0f;
    float x1 = 1.0f;
    float z1 = 1.0f;

    Vector3 nevSize;

    public GameObject _pfogo;
    public GameObject _pfogo2;
    public GameObject _pfogo3;
    public GameObject _pfogo4;
    public GameObject _pfogo5;
    public GameObject _pfogo6;
    public GameObject _pfogo7;
    public GameObject _pfogo8;

    public GameObject _gfogo;

    public GameObject _b1;
    public GameObject _b2;
    public GameObject _b3;
    public GameObject _b4;
    public GameObject _b5;
    public GameObject _b6;
    public GameObject _b7;
    public GameObject _b8;

    public GameObject _caixa_fogo1;
    public GameObject _caixa_fogo2;
    public GameObject _caixa_fogo3;
    public GameObject _caixa_fogo4;
    public GameObject _caixa_fogo5;
    public GameObject _caixa_fogo6;

    public void Diminui()
    {
        transform.localScale = new Vector3(x, y, z);
        //Destroy(this.gameObject);
    }

    public void Destroi()
    {

        if (gameObject.tag.Equals("b1"))
        {

            //paredes fogo
            _pfogo = GameObject.FindGameObjectsWithTag("pfogo")[0];
            _pfogo2 = GameObject.FindGameObjectsWithTag("pfogo2")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo2.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
        /*if (gameObject.tag.Equals("b2"))
        {

            //paredes fogo
            _pfogo3 = GameObject.FindGameObjectsWithTag("pfogo3")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            //Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo3.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
        if (gameObject.tag.Equals("b3"))
        {

            //paredes fogo
            _pfogo4 = GameObject.FindGameObjectsWithTag("pfogo4")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            //Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo4.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
        if (gameObject.tag.Equals("b4"))
        {

            //paredes fogo
            _pfogo5 = GameObject.FindGameObjectsWithTag("pfogo5")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            //Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo5.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
        if (gameObject.tag.Equals("b5"))
        {

            //paredes fogo
            _pfogo6 = GameObject.FindGameObjectsWithTag("pfogo6")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            //Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo6.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
        if (gameObject.tag.Equals("b6"))
        {

            //paredes fogo
            _pfogo7 = GameObject.FindGameObjectsWithTag("pfogo7")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            //Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo7.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
        if (gameObject.tag.Equals("b7"))
        {

            //paredes fogo
            _pfogo8 = GameObject.FindGameObjectsWithTag("pfogo8")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            //Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo8.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
        if (gameObject.tag.Equals("b8"))
        {

            //paredes fogo
            _pfogo8 = GameObject.FindGameObjectsWithTag("pfogo8")[0];

            _caixa_fogo1 = GameObject.FindGameObjectsWithTag("caixa_fogo1")[0];
            _caixa_fogo2 = GameObject.FindGameObjectsWithTag("caixa_fogo2")[0];
            _caixa_fogo3 = GameObject.FindGameObjectsWithTag("caixa_fogo3")[0];
            _caixa_fogo4 = GameObject.FindGameObjectsWithTag("caixa_fogo4")[0];
            _caixa_fogo5 = GameObject.FindGameObjectsWithTag("caixa_fogo5")[0];
            _caixa_fogo6 = GameObject.FindGameObjectsWithTag("caixa_fogo6")[0];

            //Destroy(_pfogo);
            Destroy(_caixa_fogo1);
            Destroy(_caixa_fogo2);
            Destroy(_caixa_fogo3);
            Destroy(_caixa_fogo4);
            Destroy(_caixa_fogo5);
            Destroy(_caixa_fogo6);

            //gigante fogo amarelo
            //_gfogo = GameObject.FindGameObjectsWithTag("gfogo")[0];
            //Destroy(_gfogo);

            //controe parede de fogo 2
            _pfogo8.gameObject.transform.localScale = new Vector3(x1, y1, z1);

        }
*/
    }
}
