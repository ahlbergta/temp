using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuageController : MonoBehaviour {

    public float multiplier;
    public GameObject valueTracker;
    public float guageMin;
    public float guageMax;
    private float carbonPPM;
    private Values values;

	// Use this for initialization
	void Start () {
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        float reading = guageMin + (values.carbonPPM * multiplier);
        if(reading > guageMax)
        {
            reading = guageMax;
        }
        transform.localEulerAngles = new Vector3(0, reading, 0);
	}
}
