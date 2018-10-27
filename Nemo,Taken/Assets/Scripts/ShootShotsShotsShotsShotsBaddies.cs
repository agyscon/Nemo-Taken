using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootShotsShotsShotsShotsBaddies : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.magenta);
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit callhit;
        if (Input.GetButtonDown("Fire1")) {
            if (Physics.Raycast(ray, out callhit))
            {
                Debug.Log(callhit.collider.gameObject.layer);
                Debug.Log(LayerMask.GetMask("Marlin"));
                if (callhit.collider.gameObject.layer.Equals(9))
                {

                    if (callhit.collider != null)
                    {
                        callhit.collider.enabled = false;
                        callhit.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    }
                    Debug.Log("HIT");
                }
            }
        }
	}

}
