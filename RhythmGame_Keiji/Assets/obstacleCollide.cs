using UnityEngine;
using System.Collections;

public class obstacleCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player"){
			Handheld.Vibrate ();
			Debug.Log ("Hit an Obstacle");
			
		}

	}
}
