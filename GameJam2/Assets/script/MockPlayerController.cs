using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockPlayerController : MonoBehaviour {

    public float speed = 10;

    private Rigidbody rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);


    }
}
