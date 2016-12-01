using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour
{

    private int score = 0;

    void Start()
    {
        Debug.Log("A simple bowlong game. Use Left and Right Arrows to adjust the ball and Up Arrow to shoot.");
    }

    void OnTriggerExit(Collider col)
    {
        score++;
        if(score == 10)
            Debug.Log("The score is " + score + ". Strike!");
        else
            Debug.Log("The score is " + score);
    }
    
}
