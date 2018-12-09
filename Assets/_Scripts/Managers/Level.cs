using UnityEngine;

[System.Serializable]
public class Level {
    public int unlockScore;
    public Wave wave;
    public RewardTier reward;
    public bool endTheGame;
    [HideInInspector] public bool isUnlocked = false;
}