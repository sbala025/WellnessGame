using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PigGrewMsg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numCups = SessionData.numCupsWaterInput;
        int numSleep = SessionData.numSleepHoursInput;

        if (!SessionData.unlockedPig) {
            gameObject.SetActive(false);
        }
        else if (numCups > 0 && numSleep > 0) {
            gameObject.SetActive(true);
            gameObject.GetComponent<Text>().text = "Your pig grew!";
            StartCoroutine(HideMessage());
        }
    }

    IEnumerator HideMessage() {
        yield return new WaitForSecondsRealtime(3f);
        gameObject.SetActive(false);
    }
}
