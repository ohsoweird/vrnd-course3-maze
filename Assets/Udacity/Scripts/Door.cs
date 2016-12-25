// using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	public bool locked;
	public bool hasKey;

	void Start() {
		locked = true;
		// The door is locked by default
		hasKey = false;
		// The player does not have the key at start
		//


	}


    void Update() {
        // If the door is unlocked and it is not fully raised
		if (hasKey == true) {
			// Then shift the door up
			if (transform.position.y < 20f) {
				// Animate the door raising up for as long as it is below 20 units
				transform.Translate (0, 3.5f * Time.deltaTime, 0, Space.World);
				// Animate the door raising up 3.5 units per second
				locked = false;
				// Door is not locked anymore.
			}
		}
	}

    public void Unlock() {
		// You'll need to set "locked" to true here
		locked = true;
	}


}
