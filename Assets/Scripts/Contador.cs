using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public float tiempoInicial = 10f;
    public Text tiempoTexto;
    void Start()
    {
        StartCoroutine(CuentaRegresiva());
    }
    IEnumerator CuentaRegresiva()
    {
        float tiempoRestante = tiempoInicial;
        while (tiempoRestante > 0)
        {
            tiempoTexto.text = tiempoRestante.ToString("F0");
            yield return new WaitForSeconds(1f);
            tiempoRestante--;
        }
        tiempoTexto.text = "0";
    }
}
