using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman1RoketController : MonoBehaviour
{
    //public float omur=0.1f;
    
    void Start()
    {
       
         GetComponent<Rigidbody2D>().velocity=new Vector2(-5.0f,0.0f);
            //Destroy(gameObject,omur);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        string etiket = collision.tag;
        //    print("qqq" + etiket);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
