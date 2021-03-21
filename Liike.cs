using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liike : MonoBehaviour
{

    // Robotit liikkuvat kameraa kohti
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 0.2f);
    }
}
