using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int startingHealth;
	public int currentHealth;
	public Transform drop;

	void Start(){
		currentHealth = startingHealth;

	}

	public void UpdateHealth(int amount){
		currentHealth -= amount;
		//Debug.Log("enemy health updated");
		if (currentHealth <=0){
			Death();
		}
	}

	void Death(){
		gameObject.SetActive(false);
		Instantiate(drop, transform.position, Quaternion.identity);
	}

}
