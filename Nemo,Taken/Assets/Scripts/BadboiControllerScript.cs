using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadboiControllerScript : MonoBehaviour {
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;
    public float moveSpeed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
        ApplyTurn(moveAxis, turnAxis);
    }
    private void ApplyTurn(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }
    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * Time.deltaTime * moveSpeed);
    }
    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}
