using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ampuminen : MonoBehaviour
{
    public GameObject arKamera;

    // Robotin ampuminen, robotti tuhoutuu osuman jälkeen
    void Ammu()
    {
        RaycastHit hit;
        if(Physics.Raycast(arKamera.transform.position, arKamera.transform.forward, out hit))
        {
            if(hit.transform.name == "robot1(Clone)" || hit.transform.name == "robot2(Clone)" || hit.transform.name == "robot3(Clone)")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
