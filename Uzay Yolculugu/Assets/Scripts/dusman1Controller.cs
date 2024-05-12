using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman1Controller : MonoBehaviour
{
    public GameObject _mermi;
    public float omur = 1f;
    public float saglik = 100f; //engelin sağlğı
    public float hasar = 25f; //engele çarpıldığında alınacak hasar
    public GameObject _mermiCikis1;
    public GameObject _mermiCikis2;
    public float dusman1HizX = -10f;
    public float dusman1HizY = 10f;
    public float mermiUretmeAraligi;
    public float mermiUretmeSayaci = 0.0f;


    public float hareketAraligi;
    public float hareketSayaci = 0.0f;
    bool duz = true;

    public Transform _ustSinir;
    public Transform _altSinir;

    //public Transform _ustSinirDegeri;
    //public Transform _altSinirDegeri;
    public float miny;
    public float maxy;
    void Start()
    {
        miny = _altSinir.position.y;
        maxy = _ustSinir.position.y;


        //print("mevcut:"+currentY);
        //print("min:"+miny);
        //print("max:"+maxy);
        //print("------");
        GetComponent<Rigidbody2D>().velocity = new Vector2(-3.0f, 0.0f);

    }

    void Update()
    {
        if (mermiUretmeSayaci >= mermiUretmeAraligi)
        {
            GameObject mermix = Instantiate(_mermi, _mermiCikis1.transform.position, Quaternion.identity);
            GameObject mermix2 = Instantiate(_mermi, _mermiCikis2.transform.position, Quaternion.identity);


            mermiUretmeSayaci = 0.0f;
        }
        mermiUretmeSayaci += Time.deltaTime;

        hareketEt();
    }

    public void hareketEt()
    {
        if (hareketSayaci >= hareketAraligi)
        {
            if (duz)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-3.0f, 0.0f);
            }
            else
            {
                //Vector2 currentPosition2D = new Vector2(transform.position.x, transform.position.y);
                float currentY = transform.position.y;
                if (currentY > 0)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, -7.0f);
                }
                else
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 7.0f);
                }
            }
            duz = !duz;
            hareketSayaci = 0.0f;
        }
        hareketSayaci += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string etiket = collision.name;
        // print("qqq" + etiket);

        if (collision.tag == "solDuvar")
        {
            Destroy(gameObject);
            //print("1"+other.name);
        }
        if (collision.tag == "ustDuvar")
        {
            print("ust");
            //  GetComponent<Rigidbody2D>().velocity=new Vector2(-10f,-10f);
        }
        if (collision.tag == "altDuvar")
        {
            print("alt");
            // GetComponent<Rigidbody2D>().velocity=new Vector2(-10f,10f);

        }
        else if (collision.tag == "Player")
        {
            Destroy(gameObject);

            //print("1"+other.name);
        }
    }


    public void HasarAl(float hasar)
    {
        if ((saglik - hasar) >= 0)
        {
            saglik = saglik - hasar;
        }
        else
        {
            saglik = 0;
        }
        oluMuyum();
    }

    void oluMuyum()
    {
        if (saglik <= 0) Destroy(gameObject);

    }
}
