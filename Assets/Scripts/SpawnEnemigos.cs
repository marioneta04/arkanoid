using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public GameObject Enemigo; // Asigna el prefab en el inspector
    public Vector3 areaMin;
    public Vector3 areaMax;
    void Start()
    {
        StartCoroutine(GenerarEnemigos());
    }
    IEnumerator GenerarEnemigos()
    {
        while (true)
        {
            Vector3 posicionAleatoria = new Vector3(
            Random.Range(areaMin.x, areaMax.x),
            Random.Range(areaMin.y, areaMax.y),
            Random.Range(areaMin.z, areaMax.z)
            );
            Instantiate(Enemigo, posicionAleatoria, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }

}
