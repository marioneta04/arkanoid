using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{

    public Vector2 velocidadInicial;
    private Rigidbody2D pelotitaRb;
    bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        pelotitaRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
        {
            pelotitaRb.velocity = velocidadInicial;
            isMoving = true;

        }
    }

    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.gameObject.CompareTag("Brick"))
        {
            Destroy(choque.gameObject);
        }
    }
}
