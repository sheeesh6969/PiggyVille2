using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerController : NetworkBehaviour {

	public Rigidbody rigidbody;

	void Update () {
        if(!isLocalPlayer)
        {
            return;
        }
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 7.0f;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 up = transform.TransformDirection(Vector3.up);
            rigidbody.AddForce(up * 5, ForceMode.Impulse);
            Debug.Log("Jump!");
        }

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
	}
}
