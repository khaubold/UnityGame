using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour {

	public int attackDamage;


	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other){
		//Debug.Log("triggered");
		EnemyHealth eHealth = other.GetComponent<EnemyHealth>();

		if (eHealth != null){
		eHealth.UpdateHealth(attackDamage);

	}
}
	// Update is called once per frame
	void Update () {

	}
}
