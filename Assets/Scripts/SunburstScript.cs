using UnityEngine;
using System.Collections;

public class SunburstScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            gameObject.GetComponent<ParticleSystem>().Play();
        }
    }
}

