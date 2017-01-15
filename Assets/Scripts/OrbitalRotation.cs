using UnityEngine;
using System.Collections;

public class OrbitalRotation : MonoBehaviour
{
    private Vector3 _rotationPattern;
    public float RotationSpeed;

	void Update ()
	{
	    if (gameObject.name == "Venus")
	        _rotationPattern = Vector3.up;
	    else
            _rotationPattern = Vector3.down;
        transform.RotateAround(Vector3.zero, _rotationPattern, RotationSpeed * Time.deltaTime);
    }
}
