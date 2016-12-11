using UnityEngine;
using System.Collections;

public class animationScript : MonoBehaviour {

    Animator animator;
    private bool _isOnScreen = false;

    public bool IsOnScreen
    {
        get { return _isOnScreen; }
        set { _isOnScreen = value; }
    }

    public void SetTrigger()
    {
        if (!IsOnScreen)
        {
            animator.SetBool("IsButtonPressed", true);
            IsOnScreen = true;
        }
        else
        {
            animator.SetBool("IsButtonPressed", false);
            IsOnScreen = false;
        }
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
