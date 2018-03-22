using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PrizePickup_Coin : MonoBehaviour {
	public HUDManager HudManager;
	public ThirdPersonCharacter thirdPersonCharacter;

	void Start(){
		HudManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HUDManager>();
		thirdPersonCharacter = GameObject.FindGameObjectWithTag("Player").GetComponent<ThirdPersonCharacter>();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Player")){
			gameObject.SetActive(false);
			HudManager.UpdateScore(1);
			thirdPersonCharacter.m_JumpPower++;

		}
	}

}
