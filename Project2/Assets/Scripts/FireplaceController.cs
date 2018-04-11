using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireplaceController : MonoBehaviour {

    public GameObject ValueTracker;
    private Values values;

	// Use this for initialization
	void Start () {
        values = ValueTracker.GetComponent<Values>();
	}

    private void OnTriggerEnter(Collider other)
    {
        values.coalCount++;
        Destroy(other.gameObject);
    }
}
