using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalWaterMsg : MonoBehaviour
{

    public string prefixText;

    // Start is called before the first frame update
    void Start()
    {
        int numCups = SessionData.numCupsWaterInput;

        if (numCups > 0) {
            SessionData.totalWaterCupsDrank += numCups; 
        }

        gameObject.GetComponent<Text>().text = prefixText + " " + SessionData.totalWaterCupsDrank;
    }
}
