using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalSleepMsg : MonoBehaviour
{
    public string prefixText;

    // Start is called before the first frame update
    void Start()
    {
        int numHours = SessionData.numSleepHoursInput;

        if (numHours > 0) {
            SessionData.totalHoursSlept += numHours; 
        }

        gameObject.GetComponent<Text>().text = prefixText + " " + SessionData.totalHoursSlept;
    }
}
