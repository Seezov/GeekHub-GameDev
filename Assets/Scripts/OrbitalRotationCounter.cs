using UnityEngine;
using System.Collections;

public class OrbitalRotationCounter : MonoBehaviour
{
    public int OrbitalRotCounter = 0;
    void OnTriggerExit(Collider other)
    {
        OrbitalRotCounter++;
    }
}
