using UnityEngine;
using System.Collections;

public class OrbitsScript : MonoBehaviour {

    public bool OrbitsAreVisible = true;

    void Update()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Orbits");
        if (Input.GetKeyDown(KeyCode.O) && OrbitsAreVisible)
        {
            OrbitsAreVisible = false;
            foreach (GameObject obj in objectsWithTag)
            {
                obj.GetComponent<MeshRenderer>().enabled = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.O) && !OrbitsAreVisible)
        {
            OrbitsAreVisible = true;
            foreach (GameObject obj in objectsWithTag)
            {
                obj.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
