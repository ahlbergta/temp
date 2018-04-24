using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour {

    //public float interactionRange;
    private Camera cam;
    private GameObject held;

	// Use this for initialization
	void Start () {
        cam = gameObject.GetComponent<Camera>();
        held = null;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (held == null)
            {
                RaycastHit hit;
                Ray ray = new Ray(cam.transform.position, cam.transform.forward);
                if (Physics.Raycast(ray, out hit, 2))
                {
                    held = hit.collider.gameObject;
                    held.GetComponent<Rigidbody>().useGravity = false;
                    held.GetComponent<Rigidbody>().detectCollisions = false;
                    held.transform.SetParent(cam.transform);
                }
            }
        }
        else
        {
            if (held != null)
            {
                held.GetComponent<Rigidbody>().detectCollisions = true;
                held.GetComponent<Rigidbody>().useGravity = true;
                held.transform.SetParent(null);
                held = null;
            }
        }
	}
}
