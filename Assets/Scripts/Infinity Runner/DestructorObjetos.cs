using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorObjetos : MonoBehaviour
{
    public float tiempoVivo = 0f;
    public float tiempoDeVidaMaximo = 5f;
    private void Update()
    {
        tiempoVivo += Time.deltaTime;
        if (tiempoVivo >= tiempoDeVidaMaximo)
        {
            Destroy(this.gameObject);
        }
    }
}
