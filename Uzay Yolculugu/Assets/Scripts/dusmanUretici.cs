using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanUretici : MonoBehaviour
{
    //public float omur=1f;
    public GameObject dusman;
    public GameObject dusman2;
    public GameObject dusman3;
    public float dusmanUretmeAraligi;
    public Transform _ustSinirDegeri; //diğer düşmanlar
    public Transform _altSinirDegeri;

    public Transform _ustTopSinirDegeri; //dönerek gelen düşman
    public Transform _altTopSinirDegeri;
    float miny;
    float maxy;
    float x;
    float y;
    public float dusmanUretmeSayaci = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        x = _altSinirDegeri.position.x;
        miny = _altSinirDegeri.position.y;
        maxy = _ustSinirDegeri.position.y;

        //Destroy(dusman2,omur);
    }

    void Update()
    {
        DusmanUret();
        /*if(Input.GetKey(KeyCode.K))
        {
            DusmanUret
        }*/
    }

    public void DusmanUret()
    {
        if (dusmanUretmeSayaci >= dusmanUretmeAraligi)
        {
            int randomNumber = Random.Range(1, 5);

            // print(dusmanUretmeSayaci);
            y = Random.Range(miny, maxy);
            if (randomNumber == 1)
            {
                /* GameObject mermix = Instantiate(dusman);
                 mermix.transform.position = new Vector3(x, y, 0.0f);
                 mermix.miny=miny;
                 mermix.maxy=maxy;*/

                Instantiate(dusman).transform.position = new Vector3(x, y, 0.0f);
                //Destroy(dusman,omur);
            }
            else if (randomNumber == 2)
            {
                Instantiate(dusman2).transform.position = new Vector3(x, y, 0.0f);

            }
            else if (randomNumber == 3)
            {
                Instantiate(dusman3).transform.position = new Vector3(_altTopSinirDegeri.position.x, _altTopSinirDegeri.position.y, 0.0f);

            }
            else if (randomNumber == 4)
            {
                Instantiate(dusman3).transform.position = new Vector3(_ustTopSinirDegeri.position.x, _ustTopSinirDegeri.position.y, 0.0f);
            }
            dusmanUretmeSayaci = 0.0f;
        }
        dusmanUretmeSayaci += Time.deltaTime;
    }
}
