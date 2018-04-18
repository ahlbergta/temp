using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Effects;
using UnityEngine;

public class FireplaceController : MonoBehaviour {

    public GameObject ValueTracker;
    public GameObject tempFire;
    private Values values;

	// Use this for initialization
	void Start () {
        values = ValueTracker.GetComponent<Values>();
	}

    private void OnTriggerEnter(Collider other)
    {
        values.coalCount++;
        Instantiate(tempFire, new Vector3(0.0f, 0.7f, -5.6f), Quaternion.identity);
        Destroy(other.gameObject);
    }
}
