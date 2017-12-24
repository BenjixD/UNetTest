using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[NetworkSettings(channel = 1, sendInterval = 0.01f)]
public class PlayerController : NetworkBehaviour {
	// Update is called once per frame
	void Update ()
    {
        if(!isLocalPlayer)
        {
            return;
        }

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0,0,-x);
        transform.Translate(0,y,0);

	}
}
