using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLightController : MonoBehaviour {

    public float floodThreshold;
    public GameObject light_off;
    public GameObject light_on;
    public GameObject valueTracker;
    private bool isOn;
    private bool flashing;
    private Values values;

	// Use this for initialization
	void Start () {
        isOn = false;
        flashing = false;
        Off();
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        if (flashing == false && values.waterLevel > floodThreshold)
        {
            flashing = true;
            StartCoroutine(flash());
        }
	}

    void On ()
    {
        isOn = true;
        light_off.SetActive(false);
        light_on.SetActive(true);
    }

    void Off ()
    {
        isOn = false;
        light_off.SetActive(true);
        light_on.SetActive(false);
    }

    void Toggle()
    {
        if (isOn == true)
        {
            Off();
        }
        else
        {
            On();
        }
    }

    private IEnumerator flash()
    {
        while (flashing)
        {
            Toggle();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
