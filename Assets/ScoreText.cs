using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {

	public PlayerNumbers playerNumber;
	private Text text;
	private int score;

	void OnEnable(){
		Messenger.AddListener<PlayerNumbers>("Goal", OnGoal);
		text = GetComponent<Text>();
		updateScoreText();
	}

	void OnDisable(){
		Messenger.RemoveListener<PlayerNumbers>("Goal", OnGoal);
	}

	void OnGoal(PlayerNumbers playerNum){
		if (this.playerNumber == playerNum) {
			score ++;
			updateScoreText();
		}
	}

	void updateScoreText(){
		text.text = score.ToString();

	}
}
