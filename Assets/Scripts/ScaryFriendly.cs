using UnityEngine;
using System.Collections;

public class ScaryFriendly : MonoBehaviour {

    public Light roomlight1;
    public Light roomlight2;
    public Light roomlight3;
    public Light roomlight4;
    void OnTriggerEnter(Collider col)
    {
        
        GameObject thePlayer = GameObject.Find("hangloop");
        LampMoveScript playerScript = thePlayer.GetComponent<LampMoveScript>();
        if (!playerScript.ScaryScene)
            Debug.Log("Friendly");
        else
            Debug.Log("Scary");
        playerScript.domove(playerScript.ScaryScene);
        playerScript.ScaryScene = !playerScript.ScaryScene;
        roomlight1.enabled = !roomlight1.enabled;
        roomlight2.enabled = !roomlight2.enabled;
        roomlight3.enabled = !roomlight3.enabled;
        roomlight4.enabled = !roomlight4.enabled;
        if (!playerScript.ScaryScene)
        {
            RenderSettings.ambientIntensity = 0f;
            DynamicGI.UpdateEnvironment();
        }
        else
        {
            RenderSettings.ambientIntensity = 0.8f;
            DynamicGI.UpdateEnvironment();
        }
    }

    void Start()
    {
        roomlight1.enabled = !roomlight1.enabled;
        roomlight2.enabled = !roomlight2.enabled;
        roomlight3.enabled = !roomlight3.enabled;
        roomlight4.enabled = !roomlight4.enabled;
    }
}
