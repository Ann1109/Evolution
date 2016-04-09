using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {
    Quaternion originRotation;
    float angle;

	// Use this for initialization
	void Start () {
        originRotation = transform.rotation;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        angle++;
        Quaternion rotationY = Quaternion.AngleAxis(angle, Vector3.up);
        Quaternion rotationX = Quaternion.AngleAxis(angle, Vector3.right);

        transform.rotation = rotationY * rotationX;
    }
}
