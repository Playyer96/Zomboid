using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Progression : MonoBehaviour {
    public static int Score;
    public static float Growth;
    public static bool IsGrowing;
    public static Progression instance;
    public Level[] levels;
    public GameObject levelUpEffect;
}