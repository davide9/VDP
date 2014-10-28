using UnityEngine;
using System.Collections;

public class toroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 5.325416f || transform.position.x<-5.325416f)
			transform.position = new Vector3 (-transform.position.x, transform.position.y, transform.position.z);
		if (transform.position.y > 5.325416f || transform.position.y<-5.325416f)
			transform.position = new Vector3 (transform.position.x, -transform.position.y, transform.position.z);
	}
}
