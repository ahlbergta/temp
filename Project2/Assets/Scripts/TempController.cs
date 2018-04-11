using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempController : MonoBehaviour {

    public GameObject valueTracker;
    public float multiplier;
    private float temperature;
    private Values values;

	// Use this for initialization
	void Start () {
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        temperature = values.carbonPPM * multiplier;
        transform.localScale = new Vector3(1, 1, temperature);
        values.temperature = temperature;
	}
}
