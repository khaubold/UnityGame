using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrizePickup_Bar : MonoBehaviour {

	public HUDManager HudManager;

	void Start(){

		HudManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HUDManager>();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Player")){
			gameObject.GetComponent<AudioSource>().Play();
			gameObject.SetActive(false);
			HudManager.UpdateScore(1);

		}
}




}
