using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public PlayerNumbers playerNumbers;

	void OnTriggerEnter2D(Collider2D collider){

		switch(playerNumbers){
		case PlayerNumbers.One: 
			Debug.Log ("Player two scored!");
			Messenger.Broadcast("Goal");
			break;
		case PlayerNumbers.Two:
			Debug.Log ("Player One scored!");
			Messenger.Broadcast("Goal");
			break;
		}
	}

}
