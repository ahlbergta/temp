using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Effects;
using UnityEngine;

public class FireplaceController : MonoBehaviour {

    public GameObject ValueTracker;
    public GameObject Fire;
    public float rate;
    private ParticleSystemMultiplier psm;
    private Values values;

	// Use this for initialization
	void Start () {
        psm = Fire.GetComponent<ParticleSystemMultiplier>();
        values = ValueTracker.GetComponent<Values>();
	}

    private void FixedUpdate()
    {
        Debug.Log(psm.multiplier);
        if(psm.multiplier > 1)
        {
            //psm.multiplier -= rate;
        }
        else if(psm.multiplier < 1)
        {
            psm.multiplier = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        values.coalCount++;
        psm.multiplier = 10;
        Destroy(other.gameObject);
    }
}
