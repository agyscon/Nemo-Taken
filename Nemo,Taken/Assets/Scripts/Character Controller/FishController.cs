using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour {
    public float movementSpeed = 5;

	
	// Update is called once per frame
	void Update () {
        float translateX = Input.GetAxis("Horizontal") * 5 * Time.deltaTime;
        float translateZ = Input.GetAxis("Vertical") * 5 * Time.deltaTime;
        transform.Translate(translateX, 0, translateZ);
	}
}
