using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLightController : MonoBehaviour {

    public float floodThreshold;
    public GameObject light_off;
    public GameObject light_on;
    public GameObject valueTracker;
    private Values values;

	// Use this for initialization
	void Start () {
        Off();
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        if (values.waterLevel > floodThreshold)
        {
            On();
        }
	}

    void On ()
    {
        light_off.SetActive(false);
        light_on.SetActive(true);
    }

    void Off ()
    {
        light_off.SetActive(true);
        light_on.SetActive(false);
    }
}
