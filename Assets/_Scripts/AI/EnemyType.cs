using UnityEngine;

[System.Serializable]
public class EnemyType {
    public GameObject enemyPrefab;
    [Range (0f, 1f)] public float spawnChance;
}