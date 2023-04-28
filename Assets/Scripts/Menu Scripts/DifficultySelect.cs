using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelect:MonoBehaviour
{
    public static bool easy = false;
    public static bool medium = false;
    public static bool hard = false;

    public static void SelectEasyDifficulty()
    {
        easy = true;
        medium = false;
        hard = false;
    }

    public static void SelectMediumDifficulty()
    {
        easy = false;
        medium = true;
        hard = false;
    }

    public static void SelectHardDifficulty()
    {
        easy = false;
        medium = false;
        hard = true;
    }
}
