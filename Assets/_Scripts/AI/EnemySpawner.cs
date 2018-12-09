using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] private float startSpawnRadius;
	[SerializeField] private float spawnRadius;

	[HideInInspector] public Wave currentWave;

	private float nextSpawnTime = 1f;

	void Update () {
		if (Progression.IsGrowing) return;

		spawnRadius = startSpawnRadius * Progression.Growth;

		if (Time.time >= nextSpawnTime) {
			SpawnWave ();
			nextSpawnTime = Time.time + 1f / currentWave.spawnRate;
		}
	}

	void SpawnWave () {
		foreach (EnemyType eType in currentWave.enemies) {
			if (Random.value >= eType.spawnChance) {
				SpawnEnemy (eType.enemyPrefab);
			}
		}
	}

	void SpawnEnemy (GameObject enemyPrefab) {

		Vector3 spanwnPos = PlayerController.Position;
		spanwnPos += Random.insideUnitSphere.normalized * spawnRadius;
		Instantiate (enemyPrefab, spanwnPos, Quaternion.identity);
	}
}