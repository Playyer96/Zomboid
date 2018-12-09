using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

	public PlayerData playerData;

	public void TakeDamage (int amount) {
		playerData.health -= amount;

		if (playerData.health <= 0)
			Die ();
	}

	public virtual void Die () {
		GameObject effect = Instantiate (playerData.deathEffect, transform.position, transform.rotation);
		effect.transform.localScale = transform.localScale;
		Destroy (effect, 10f);
		Destroy (gameObject);
	}
}