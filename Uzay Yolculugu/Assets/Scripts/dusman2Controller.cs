using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman2Controller : MonoBehaviour
{
    public float omur=1f;
    public GameObject _mermi;
    public float saglik=100f; //engelin sağlğı
    public float hasar=25f; //engele çarpıldığında alınacak hasar
    public GameObject _mermiCikis;  


      public float mermiUretmeAraligi=0.4f;
        public float mermiUretmeSayaci=0.0f;
    void Start()
    {
          // Destroy(gameObject,omur);
        GetComponent<Rigidbody2D>().velocity=new Vector2(-3.0f,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
                if(mermiUretmeSayaci>=mermiUretmeAraligi)
        {
                GameObject mermix =Instantiate(_mermi, _mermiCikis.transform.position, Quaternion.identity);


                    mermiUretmeSayaci=0.0f; 
        }
        mermiUretmeSayaci+=Time.deltaTime;
    }

        private void OnTriggerEnter2D(Collider2D collision)
    { 
           string etiket = collision.name;
         //   print("qqq" + etiket);
        if(collision.tag=="solDuvar")
        {
              Destroy(gameObject);
            //print("1"+other.name);
        }
        else if(collision.tag=="Player")
        {
              Destroy(gameObject);
            //print("1"+other.name);
        }
    }


    public void HasarAl(float hasar)
    {
        if((saglik-hasar)>=0)
        {
            saglik=saglik-hasar;
        }
        else{
            saglik=0;
        }
        oluMuyum();
    }

    void oluMuyum()
    {
       if(saglik<=0) Destroy(gameObject);

    }
}
