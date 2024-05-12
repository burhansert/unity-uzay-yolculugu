using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class oyunYoneticiKod : MonoBehaviour
{
    int puan;
    public int yasam;
    public TextMeshProUGUI txtPuan;
    public TextMeshProUGUI txtYasam;
    void PuanAta(int puanx)
    {
        puan = puanx;
        txtPuan.text = "Puan:" + puan;
    }

    void YasamAta(int yasamxx)
    {
        yasam = yasamxx;
        txtYasam.text = "Yasam:" + yasam;
    }

    public void puanArtir(Puanlar yenipuan)
    {
        puan = puan + (int)yenipuan;
        PuanAta(puan);

    }

    public void yasamAzalt(int yasamx)
    {
        if (yasam - yasamx < 0)
        {
            yasam=0;
        }
        else
        {
            yasam = yasam - yasamx;   
        }
        YasamAta(yasam);
    }
    void Start()
    {
        puan = 0;
        PuanAta(puan);
        yasam = 900;
        YasamAta(yasam);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
