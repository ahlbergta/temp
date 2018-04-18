using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempController : MonoBehaviour {

    public GameObject valueTracker;
    public float multiplier;
    public float maxScale;
    private float temperature;
    private Values values;

	// Use this for initialization
	void Start () {
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        float reading = 1 + (values.temperature * multiplier);
        if(reading > maxScale)
        {
            reading = maxScale;
        }
        transform.localScale = new Vector3(1, 1, reading);
	}
}
