using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalToTemp : MonoBehaviour {

    public GameObject valueTracker;
    private Values values;

    // Use this for initialization
    void Start () {
        values = valueTracker.GetComponent<Values>();
    }

    // Update is called once per frame
    void Update () {
        //coal count will represent projection of greenhouse gas
        //emission over the next 100 years in RCP (Representative Concentration Pathways)
        //links for data are below
        //https://19january2017snapshot.epa.gov/sites/production/files/styles/medium/public/2016-07/scenariotempgraph_0.jpg
        //https://19january2017snapshot.epa.gov/sites/production/files/2016-07/scenarioco2.jpg

        switch (values.coalCount)
        {
            //greenhouse emission as it is today
            case 0:
                values.temperature = 0.0f;
                values.carbonPPM = 0;
                break;
             //greenhouse emission at lowest projection (RCP 2.6)
            case 1:
                values.temperature = 1.0f;
                values.carbonPPM = 42;
                break;
             //greenhouse emission at lower projection (RCP 4.5)
            case 2:
                values.temperature = 2.0f;
                values.carbonPPM = 192;
                break;
             //greenhouse emission at higher projection (RCP 6.0)
            case 3:
                values.temperature = 3.0f;
                values.carbonPPM = 392;
                break;
             //greenhouse emission at highest projection (RCP 8.5)
            case 4:
                values.temperature = 5.0f;
                values.carbonPPM = 992;
                break;
            //no data for this but emphasis on disaster
            default:
                StartCoroutine(doomsday());
                break;
        }
    }
    //once the user goes beyond defined temp and carbon levels
    //doomsday scenario activates and the temp and carbon levels rise
    private IEnumerator doomsday()
    {
        while (values.temperature < 999.0 && values.carbonPPM < 9999)
        {
            
            values.temperature += 0.5f;
            values.carbonPPM += 10;
            yield return new WaitForSeconds(.5f);
        }
    }
}