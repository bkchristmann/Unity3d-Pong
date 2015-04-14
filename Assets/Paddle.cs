using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float speed;
	public float max;
	public float min;
	public PlayerNumbers playerNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (playerNum == PlayerNumbers.One) {
			if (Input.GetKey(KeyCode.UpArrow)) {
				transform.Translate (0f, speed * Time.deltaTime, 0f);
			}
			
			if (Input.GetKey(KeyCode.DownArrow)) {
				transform.Translate (0f, -speed * Time.deltaTime, 0f);
			}
		}
		
		if (playerNum == PlayerNumbers.Two) {
			if (Input.GetKey(KeyCode.W)) {
				transform.Translate (0f, speed * Time.deltaTime, 0f);
			}
			
			if (Input.GetKey(KeyCode.S)) {
				transform.Translate (0f, -speed * Time.deltaTime, 0f);
			}
		}

		if (transform.position.y > max) {
			transform.position = new Vector3(transform.position.x, 10f, 0f);
		}
		if (transform.position.y < min) {
			transform.position = new Vector3(transform.position.x, -10f, 0f);
		}
	}


}
