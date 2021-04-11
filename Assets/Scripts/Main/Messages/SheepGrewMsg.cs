using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheepGrewMsg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numCups = SessionData.numCupsWaterInput;
        int numSleep = SessionData.numSleepHoursInput;

        if (numCups < 1 && numSleep < 1) {
            gameObject.SetActive(false);
        }
        else {
            gameObject.SetActive(true);
            gameObject.GetComponent<Text>().text = "Your sheep grew!";
            StartCoroutine(HideMessage());
        }
    }

    IEnumerator HideMessage() {
        yield return new WaitForSecondsRealtime(3f);
        gameObject.SetActive(false);
    }
}
