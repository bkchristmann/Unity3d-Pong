using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float randomAngle = Random.Range (0f, 360f);
		Vector2 startVelocity = new Vector2();
		startVelocity.x = 5 * Mathf.Cos (randomAngle * Mathf.Deg2Rad);
		startVelocity.y = 5 * Mathf.Sin (randomAngle * Mathf.Deg2Rad);
		rigidbody2D.velocity = startVelocity;

	}
	
	// Update is called once per frame
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

}
