using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketController : MonoBehaviour
{
    public float zarar = 50f;
    public float omur = 3f;
    oyunYoneticiKod oyunYoneticiX;
    void Start()
    {
        //oyunYoneticiX=GameObject.Find("oyunYonetici").GetComponent<oyunYonetici>();
        oyunYoneticiX = GameObject.Find("oyunYonetici").GetComponent<oyunYoneticiKod>();

        Destroy(gameObject, omur);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "dusman1")
        {
            Destroy(collision.gameObject);
            oyunYoneticiX.puanArtir(Puanlar.DusmanVuruldu);
            //print("1"+other.name);
        }
        else if (collision.tag == "dusman2")
        {
            Destroy(collision.gameObject);
            oyunYoneticiX.puanArtir(Puanlar.DusmanVuruldu);
            //print("1"+other.name);
        }
        else if (collision.tag == "dusman3")
        {
            Destroy(collision.gameObject);
            oyunYoneticiX.puanArtir(Puanlar.DusmanVuruldu);
            //print("1"+other.name);
        }
        else if (collision.tag == "dusmanroket")
        {
            Destroy(collision.gameObject);
            oyunYoneticiX.puanArtir(Puanlar.DusmanVuruldu);
            //print("1"+other.name);
        }
        if (collision.tag == "sagDuvar")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "altDuvar")
        {

        }
        if (collision.tag == "ustDuvar")
        {

        }


        //string etiket = collision.tag;
        // print("qqq" + tag);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
