using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace EnemyAI {
	[RequireComponent (typeof (NavMeshAgent))]
	public class EnemyStateController : MonoBehaviour {

		[SerializeField] private bool aiActive;
		[SerializeField] private EnemyData enemyData;
		private GameObject target;

		private NavMeshAgent navMeshAgent;
		private new Transform transform;

		float dist;

		private void Start () {
			target = GameObject.FindGameObjectWithTag ("Player");
			transform = GetComponent<Transform> ();
			navMeshAgent = GetComponent<NavMeshAgent> ();
		}

		private void Update () {
			if (!aiActive) return;

			Chase ();
		}

		void Chase () {
			if (target != null) {
				navMeshAgent.destination = target.transform.position;
				Vector3 targetDir = target.transform.position - transform.position;
				navMeshAgent.isStopped = false;
			}
		}
	}
}