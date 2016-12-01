using UnityEngine;
using System.Collections;

public class PushBallScript : MonoBehaviour
{

    public float pushforce = 500f;

    void Start()
    {
        Debug.Log("A simple bowlong game. Use Left and Right Arrows to adjust the ball and Up Arrow to shoot.");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            pushforce += 10f;
        if (Input.GetKeyUp(KeyCode.UpArrow))
            GetComponent<Rigidbody>().AddForce(Vector3.forward * pushforce);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-0.1f,0,0);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(0.1f,0 ,0);
    }
}
