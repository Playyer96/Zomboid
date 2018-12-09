using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Entities/Player")]
public class PlayerData : ScriptableObject {

	public float speed;
	public float rotationSpeed;
	public int health;
	public GameObject deathEffect;

}