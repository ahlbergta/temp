using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour {

    public float multiplier;
    public GameObject valueTracker;
    private float waterLevel;
    private Values values;

	// Use this for initialization
	void Start () {
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        waterLevel = values.glacierMelt * multiplier;
        transform.localPosition = new Vector3(0, waterLevel, 0);
        values.waterLevel = waterLevel;
	}
}
