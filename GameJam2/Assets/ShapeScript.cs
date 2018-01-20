using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript : MonoBehaviour {

	public GameObject target; // This is the reference for the current shape

	// Stores  "which shape" property
	public string CurrentShape;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	// Function to check for player collision
	public void OnCollisionEnter(Collision collision){
		// Rock Paper Scissors Scenarios

		// Make sure collission  with an enemy
		if(collision.gameObject.tag == "Enemy"){
			ShapeScript enemyScript = collision.gameObject.GetComponent<ShapeScript> ();

			// Rock conditions
			if (CurrentShape == "Rock") {
				if (enemyScript.CurrentShape == "Scissors") {
					Destroy (collision.gameObject);
				}
				if (enemyScript.CurrentShape == "Paper") {
					CurrentShape = "Paper";
					// TODO: Need to add some sort of animation/mesh transformation here
				}
			}

			// Rock conditions
			if (CurrentShape == "Paper") {
				if (enemyScript.CurrentShape == "Rock") {
					Destroy (collision.gameObject);
				}
				if (enemyScript.CurrentShape == "Scissors") {
					CurrentShape = "Scissors";
					// TODO: Need to add some sort of animation/mesh transformation here
				}
			}

			// Rock conditions
			if (CurrentShape == "Scissors") {
				if (enemyScript.CurrentShape == "Paper") {
					Destroy (collision.gameObject);
				}
				if (enemyScript.CurrentShape == "Rock") {
					CurrentShape = "Rock";
					// TODO: Need to add some sort of animation/mesh transformation here
				}
			}
		}
	}
}
