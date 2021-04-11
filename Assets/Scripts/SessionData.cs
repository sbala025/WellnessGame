using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Session Data that is shared across scenes
public class SessionData : MonoBehaviour
{

    // Scale Data
    public static Vector3 sheepScale;
    public static Vector3 pigScale;

    // Unlock Data
    public static bool unlockedPig = false;

    public static int totalHoursSlept = 0;
    public static int totalWaterCupsDrank = 0;

    // Required Pig Growth
    public static int pigReqHrsSlept = 24;
    public static int pigReqWaterDrank = 20;


    // Input Data
    public static int numCupsWaterInput = -1; // Default
    public static int numSleepHoursInput = -1; // Default

}
