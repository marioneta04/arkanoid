using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pelota2 : MonoBehaviour
{
    public Vector2 velocidadInicial;
    private Rigidbody2D pelotitaRb;
    bool isMoving;
    public Score sumarScore;
    public int puntos;
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
        victory();
    }

    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.gameObject.CompareTag("Brick"))
        {
            sumarScore.Contador(puntos);
            Destroy(choque.gameObject);
        }

        if (choque.gameObject.CompareTag("Dead"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(1);
    }

    void victory()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
        if (bricks.Length == 0)
        {
            SceneManager.LoadScene(1);
        }

    }
}
