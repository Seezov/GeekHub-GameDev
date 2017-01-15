using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OrbitsText : MonoBehaviour {
    // Update is called once per frame
    void Update () {

        GameObject OrbitsInfo = GameObject.Find("OrbitsInfo");
        Text OrbitsText = OrbitsInfo.GetComponent<Text>();
        GameObject orbits = GameObject.Find("Orbits");
        OrbitsScript orbitsScript = orbits.GetComponent<OrbitsScript>();
        bool OAV = orbitsScript.OrbitsAreVisible;
        if (OAV)
            OrbitsText.text = "Orbits are ON";
        else if (!OAV)
            OrbitsText.text = "Orbits are OFF";
    }
}
