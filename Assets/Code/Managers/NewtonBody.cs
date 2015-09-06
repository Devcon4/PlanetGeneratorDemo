using UnityEngine;
using System.Collections;

public class NewtonBody : MonoBehaviour {

    public float rotationSpeed;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (rotationSpeed != 0) {
            float angle = rotationSpeed / 60;
            transform.Rotate(transform.up, angle);
        }
	}
}
