using UnityEngine;
using System.Collections;

public class FlickeringScript : MonoBehaviour {

    float minFlickerSpeed  = 2.1f;
    float maxFlickerSpeed  = 3.0f;
    public Light light;
 
    void Update()
    {
        GameObject thePlayer = GameObject.Find("hangloop");
        LampMoveScript playerScript = thePlayer.GetComponent<LampMoveScript>();
        if (!playerScript.ScaryScene)
            light.intensity = (Random.Range(minFlickerSpeed, maxFlickerSpeed));
        else
            light.intensity = 2.5f;
    }
}
