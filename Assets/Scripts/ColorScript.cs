using UnityEngine;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class ColorScript : MonoBehaviour
{
    void Update()
    {
        GameObject player = GameObject.Find("hip");
        float distance = Vector3.Distance(transform.position, player.transform.position);
        Color doorColor = new Color(1.0f - distance/20, 1.0f - distance / 20, 1.0f - distance / 20);
        GetComponent<Renderer>().material.color = doorColor;
    }
}