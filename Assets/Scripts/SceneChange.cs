using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public GameObject door;
    public GameObject player;

    void Update ()
	{
	    var collisionDistance = 2.0f;
        float distance = Vector3.Distance(door.transform.position, player.transform.position);
        if (distance < collisionDistance)
        {
            SceneManager.LoadScene("HomeTask2_Scene2");
        }
    }
}
