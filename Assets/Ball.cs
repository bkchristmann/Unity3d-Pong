using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	void OnEnable() {
		Messenger.AddListener<PlayerNumbers>("Goal", OnGoal);
	}
	
	void OnDisable(){
		Messenger.RemoveListener<PlayerNumbers>("Goal", OnGoal);
	}

	void Start () {
		float randomAngle = Random.Range (0f, 360f);
		Vector2 startVelocity = new Vector2();
		startVelocity.x = 5 * Mathf.Cos (randomAngle * Mathf.Deg2Rad);
		startVelocity.y = 5 * Mathf.Sin (randomAngle * Mathf.Deg2Rad);
		rigidbody2D.velocity = startVelocity;

	}
	

	void Update () {



	}

	void OnCollisionEnter (Collision collision) {
		Vector3 normal = collision.contacts[0].normal;

		Vector3 newVelocity = rigidbody.velocity.normalized;

		if (normal.x == 0) {
			newVelocity.x *= -1;
		}
		if( normal.y == 0 ) {
			newVelocity.y *= -1;
		}

		newVelocity *= 5;

		rigidbody.velocity = newVelocity;

	}

	void OnGoal(PlayerNumbers Player){
		transform.position = Vector3.zero;
		Start ();
	}

	void OnCollisionExit2D(Collision2D collision){
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.velocity *= 1.05f;
	}

}
