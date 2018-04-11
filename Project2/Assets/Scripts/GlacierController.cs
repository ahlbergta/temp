using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlacierController : MonoBehaviour {

    public float multiplier;
    public GameObject valueTracker;
    private float glacierMelt;
    private Values values;

	// Use this for initialization
	void Start () {
        values = valueTracker.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
        glacierMelt = (1-values.temperature) * multiplier;
        transform.localScale = new Vector3(1, glacierMelt, 1);
        values.glacierMelt = glacierMelt;
	}
}
