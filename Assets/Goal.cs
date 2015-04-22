using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public PlayerNumbers playerNumbers;

	void OnTriggerEnter2D(Collider2D collider){

		switch(playerNumbers){
		case PlayerNumbers.One: 
			Messenger.Broadcast("Goal",PlayerNumbers.One);
			break;
		case PlayerNumbers.Two:
			Messenger.Broadcast("Goal",PlayerNumbers.Two);
			break;
		}
	}

}
