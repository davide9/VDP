using UnityEngine;
using System.Collections;

public class fighter : MonoBehaviour {

	private float speed = 2f;
	private float rotation_speed = 120f;
	private Rigidbody2D rigidbody;
	public GameObject prefab_missile;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> () as Rigidbody2D;
	}

	bool GetRight(){
		return Input.GetKey (KeyCode.RightArrow);
		}

	bool GetLeft(){
		return Input.GetKey (KeyCode.LeftArrow);
	}

	bool GetThrust(){
		return Input.GetKey (KeyCode.UpArrow);
	}

	bool GetFire(){
		return Input.GetKeyDown (KeyCode.Space);
	}
	
	// Update is called once per frame
	void Update () {
		if (GetLeft ()) {
			transform.Rotate(Vector3.forward * rotation_speed * Time.deltaTime);
				}

		if (GetRight ()) {
			transform.Rotate(Vector3.forward * -rotation_speed * Time.deltaTime);
		}

		if (GetThrust ()) {
						// Time.deltaTima è il tempo passato dall'ultimo update.
						//transform.position = transform.position + transform.up * speed * Time.deltaTime;

						//Usiamo la fisica
						rigidbody.AddForce (transform.up * speed);
				}

		if (GetFire ()) {
			GameObject missile = Instantiate(prefab_missile, transform.position + transform.up * 0.45f, transform.rotation) as GameObject;
		}


	}
}
