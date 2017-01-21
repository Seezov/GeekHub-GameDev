using UnityEngine;
using System.Collections;
using UnityEngine.VR.WSA;

public class AudioScript : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        GameObject player = GameObject.Find("Player");
        float distance = Vector3.Distance(transform.position, player.transform.position);
        Debug.Log("Distance to " + gameObject.name + " is " + distance);
        float volume = 1 - distance/25;
        GetComponent<AudioSource>().volume = volume;
    }
}
