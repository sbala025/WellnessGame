using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepGrowth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SessionData.sheepScale.x > 0) {
            Vector3 newScale = SessionData.sheepScale;

            if (SessionData.numCupsWaterInput > 0) {
                int numCups = SessionData.numCupsWaterInput;
                float scaleIncrease = 0.003f * ((float) numCups);
                newScale = newScale + new Vector3(scaleIncrease, scaleIncrease, 0F);
            }

            if (SessionData.numSleepHoursInput > 0) {
                int numSleep = SessionData.numSleepHoursInput;
                float scaleIncrease = 0.005f * ((float) numSleep);
                newScale = newScale + new Vector3(scaleIncrease, scaleIncrease, 0F);
            }

            transform.localScale = newScale;
            SessionData.sheepScale = newScale;
        }
        else {
           SessionData.sheepScale = transform.localScale; 
        }
    }
}
