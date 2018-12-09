using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity {

	public int damage = 1;
	public int reward = 1;

	private void OnCollisionEnter (Collision other) {
		Player player = other.collider.GetComponent<Player> ();

		if (player != null) {
			// if(!Progression.IsGrowing)
			player.TakeDamage (damage);

			base.Die ();
		}
	}

	public override void Die () {
		// Progression.instance.AddScore (reward);
		base.Die ();
	}

	public void Remove () {
		base.Die ();
	}
}