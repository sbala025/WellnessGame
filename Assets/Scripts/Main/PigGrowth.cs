using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PigGrowth : MonoBehaviour
{
    public Text unlockPigMsg;

    // Start is called before the first frame update
    void Start()
    {
        if (SessionData.pigScale.x > 0 &&
             SessionData.totalHoursSlept > SessionData.pigReqHrsSlept &&
             SessionData.totalWaterCupsDrank > SessionData.pigReqWaterDrank
            ) {
            gameObject.SetActive(true);
            Vector3 newScale = SessionData.pigScale;

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
            SessionData.pigScale = newScale;

            if (!SessionData.unlockedPig) {
                displayUnlockPigMsg();
                SessionData.unlockedPig = true;
            }
        }
        else {
           SessionData.pigScale = transform.localScale; 
           gameObject.SetActive(false);
        }
    }

    private void displayUnlockPigMsg() {
        unlockPigMsg.gameObject.SetActive(true);
        unlockPigMsg.text = "You got a sheep!";
        StartCoroutine(HideMessage());
    }

    IEnumerator HideMessage() {
        yield return new WaitForSecondsRealtime(3f);
        unlockPigMsg.gameObject.SetActive(false);
    }
}
