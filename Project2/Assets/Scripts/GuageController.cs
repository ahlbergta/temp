using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuageController : MonoBehaviour {

    public float multiplier;
    public GameObject valueTracker;
    private float carbonPPM;
    private Values values;

	// Use this for initialization
	void Start () {
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        carbonPPM = values.coalCount * multiplier;
        transform.localEulerAngles = new Vector3(0, carbonPPM, 0);
        values.carbonPPM = carbonPPM;
	}
}
