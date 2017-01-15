using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlanetText : MonoBehaviour {

    void OnMouseDown()
    {

        GameObject PlanetInfo = GameObject.Find("PlanetInfo");
        Text PlanetText = PlanetInfo.GetComponent<Text>();

        GameObject planet = gameObject;
        GameObject OrbitRotInfo = GameObject.Find(planet.name + "Trigger");
        OrbitalRotationCounter OrbitRotScript = OrbitRotInfo.GetComponent<OrbitalRotationCounter>();
        if (planet.name == "Saturn")
        {
            GameObject Saturn = GameObject.Find("SaturnModel");
            RotationCounter planetScript2 = Saturn.GetComponent<RotationCounter>();
            PlanetText.text = planet.name + " turned around " + "it's center of mass " + planetScript2.RotCounter +
                              " times and " + OrbitRotScript.OrbitalRotCounter + " times around the Sun";
        }
        else
        {
            RotationCounter planetScript2 = planet.GetComponent<RotationCounter>();
            PlanetText.text = planet.name + " turned around " + "it's center of mass " + planetScript2.RotCounter +
                              " times and " + OrbitRotScript.OrbitalRotCounter + " times around the Sun";
        }
    }
}
