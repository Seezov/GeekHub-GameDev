using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 5.0f;
    public float mouseSensitivity = 5.0f;
    public float jumpSpeed = 20.0f;

    float verticalRotation = 0;
    public float upDownRange = 60.0f;
    private bool _cursorLocked = false;
    float verticalVelocity = 0;

    CharacterController characterController;

    public bool CursorLocked
    {
        get { return _cursorLocked; }
        set { _cursorLocked = value; }
    }

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        CursorLocked = true;
        characterController = GetComponent<CharacterController>();
    }




    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.F) && CursorLocked)
        {
            Cursor.lockState = CursorLockMode.None;
            CursorLocked = false;
        }
        if (Input.GetKey(KeyCode.F) && !CursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            CursorLocked = true;
        }
        // Rotationa
        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);


        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);


        // Movement

        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        verticalVelocity += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded && Input.GetButton("Jump"))
        {
            verticalVelocity = jumpSpeed;
        }

        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);

        speed = transform.rotation * speed;


        characterController.Move(speed * Time.deltaTime);
    }
}
