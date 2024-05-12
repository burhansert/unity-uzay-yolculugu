using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman3Controller : MonoBehaviour
{
    public float omur;
    public Rigidbody2D _rigidBody;
    public float rotationSpeed;
    void Start()
    {
        Destroy(gameObject, omur);

        GameObject otherObject = GameObject.Find("uzayMekigi");
        Vector2 otherObjectPosition = new Vector2(otherObject.transform.position.x, otherObject.transform.position.y);

        _rigidBody = GetComponent<Rigidbody2D>();
        float moveSpeed = 2f; // Hareket hızı
        Vector2 direction = otherObjectPosition - (Vector2)transform.position;
        direction.Normalize();
        _rigidBody.velocity = direction * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string etiket = collision.name;

        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
