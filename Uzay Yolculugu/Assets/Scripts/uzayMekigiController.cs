using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;
public class uzayMekigiController : MonoBehaviour
{
    Rigidbody2D player;

    public GameObject _mermi;
    float moveSpeed = 10f;
    public GameObject _mermiCikis;
    public float mermiHizi = 10f;
    oyunYoneticiKod oyunYoneticiX;

    public Button btnYeniOyun;

    public TextMeshProUGUI txtKaybettin;

    public Transform _ustSinirDegeri;
    public Transform _altSinirDegeri;
    void Start()
    {
        btnYeniOyun.gameObject.SetActive(false);
        txtKaybettin.gameObject.SetActive(false);
        btnYeniOyun.onClick.AddListener(YeniOyun);

        oyunYoneticiX = GameObject.Find("oyunYonetici").GetComponent<oyunYoneticiKod>();
        player = this.GetComponent<Rigidbody2D>();
    }

    void YeniOyun()
    {
        string sahneAdi = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sahneAdi);

        Time.timeScale = 1f;
        //print("Yeni Oyun Başlatıldı!");
        //btnYeniOyun.gameObject.SetActive(false);
    }

    void Update()
    {
        move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject mermix = Instantiate(_mermi, _mermiCikis.transform.position, Quaternion.identity);

            Rigidbody2D mermiRigidbody = mermix.GetComponent<Rigidbody2D>();

            mermiRigidbody.velocity = Vector2.right * mermiHizi;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "dusman1")
        {
            oyunYoneticiX.yasamAzalt((int)Hasarlar.dusman1Carpti);
            //print("1"+other.name);
        }
        else if (collision.tag == "dusman2")
        {
            oyunYoneticiX.yasamAzalt((int)Hasarlar.dusman2Carpti);
        }
        else if (collision.tag == "dusman3")
        {
            oyunYoneticiX.yasamAzalt((int)Hasarlar.dusman3Carpti);
        }
        else if (collision.tag == "dusmanroket")
        {
            oyunYoneticiX.yasamAzalt((int)Hasarlar.dusmanRoketiCarpti);
        }
        else if (collision.tag == "ustDuvar")
        {
            //moveSpeed = 0f;
            //oyunYoneticiX.yasamAzalt((int)Hasarlar.dusman2Carpti);
        }
        else if (collision.tag == "altDuvar")
        {
            // moveSpeed = 0f;
            //oyunYoneticiX.yasamAzalt((int)Hasarlar.dusman2Carpti);
        }
        else
        {

        }
        oluMuyum();
    }

    void move()
    {
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, Input.GetAxis("Vertical") * moveSpeed);
    }

    void oluMuyum()
    {
        //oyunYoneticiX.yasam
        if (oyunYoneticiX.yasam <= 0)
        {
            // Destroy(gameObject);
            btnYeniOyun.gameObject.SetActive(true);
            txtKaybettin.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
