using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

	public int attackDamage;
	public HUDManager HUDManager;
	public Animator anim;
	// Use this for initialization
	void Start () {
		HUDManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HUDManager>();
		anim = GetComponentInParent<Animator>();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Player"))
		//&& anim.GetCurrentAnimatorStateInfo(0).IsName("Attacking"))
		{
			HUDManager.UpdateHealth(attackDamage);

		}



	}



}
