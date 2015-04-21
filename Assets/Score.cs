using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	void OnEnable() {
		Messenger.AddListener("Goal", OnGoal);
	}

	void OnDisable(){
		Messenger.RemoveListener ("Goal", OnGoal);
	}

	void OnGoal(){
		Debug.Log ("Test");
	}

}
