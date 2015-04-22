using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	void OnEnable() {
		Messenger.AddListener<PlayerNumbers>("Goal", OnGoal);
	}

	void OnDisable(){
		Messenger.RemoveListener<PlayerNumbers>("Goal", OnGoal);
	}

	void OnGoal(PlayerNumbers Player){

		switch(Player){
		case PlayerNumbers.One: 
			Debug.Log("Player One Scored!");
			break;
		case PlayerNumbers.Two:
			Debug.Log("Player Two Scored!");
			break;
		}
	}

}
