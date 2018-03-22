using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour {

	public int MasterScore;
	public Text ScoreText;
	public int StartingHealth;
	public int CurrentHealth;
	public Slider PlayerHealthBar;

	void Start(){
		MasterScore = 0;
		ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		PlayerHealthBar = GameObject.Find("PlayerHealthBar").GetComponent<Slider>();
		ScoreText.text = "Score: " + MasterScore;
		CurrentHealth = StartingHealth;

	}

	public void UpdateScore(int amount){
		MasterScore += amount;
		ScoreText.text = "Score: " + MasterScore;
}

	public void UpdateHealth(int amount){
		CurrentHealth -= amount;
		PlayerHealthBar.value = CurrentHealth;

		if (CurrentHealth<=0){
			Die();
		}
	}

	public void Die(){
			SceneManager.LoadScene("Level_01");
	}

}
