using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {	

	void Update ()
	{
	    var collisionDistance = 2.5f;
        GameObject door = GameObject.Find("door");
        GameObject player = GameObject.Find("hip");
        float distance = Vector3.Distance(door.transform.position, player.transform.position);
        if (distance < collisionDistance)
        {
            SceneManager.LoadScene("HomeTask2_Scene2");
        }
    }
}
