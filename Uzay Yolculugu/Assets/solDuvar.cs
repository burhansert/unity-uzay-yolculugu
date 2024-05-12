using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solDuvar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
           string etiket = collision.name;
          // print("qqq" + etiket);

        if(collision.tag=="solDuvar")
        {
            //Destroy(collision.gameObject);
            //print("1"+other.name);
        }
    }
}
