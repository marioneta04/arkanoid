using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoobjeto : MonoBehaviour
{
    public float distancia = 2f;
    public float velocidad = 1f;
    public float tiempoDeEspera;

    private void Start()
    {
        StartCoroutine(MoverObjeto());

    }

    IEnumerator MoverObjeto()
    {
        while (true)
        {
            Vector3 objetivoArriba = transform.position + Vector3.up * distancia;
            Vector3 objetivoAbajo = transform.position;

            while (transform.position != objetivoArriba)
            {
                transform.position = Vector3.MoveTowards(transform.position, objetivoArriba, velocidad * Time.deltaTime);
                yield return null;
            }

            yield return new WaitForSeconds(tiempoDeEspera);

            while (transform.position != objetivoAbajo)
            {
                transform.position = Vector3.MoveTowards(transform.position, objetivoAbajo, velocidad * Time.deltaTime);
                yield return null;
            }
        }

        yield return new WaitForSeconds(tiempoDeEspera);
    }
}
