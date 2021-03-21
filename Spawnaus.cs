using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnaus : MonoBehaviour
{
    public Transform[] spawnausPaikka;
    public GameObject[] robotit;
    
    // Aloitus
    void Start()
    {
        StartCoroutine(AloitaSpawnaus());
    }

    //Robotit spawnaavat
    IEnumerator AloitaSpawnaus()
    {
        yield return new WaitForSeconds(4);
        for(int i = 0; i < 3; i++)
        {
            Instantiate(robotit[i], spawnausPaikka[i].position, Quaternion.identity);
        }
        StartCoroutine(AloitaSpawnaus());
    }
}
