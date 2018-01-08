using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {

	private Vector3 inputValue;
	
	// Update is called once per frame
	void Update () {
		//Only Allow the Local Player to move when input is given
		if(!isLocalPlayer){
			return;
		}
		//Player Movement
		inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

		transform.Translate(inputValue);

	}

	public override void OnStartLocalPlayer(){
		GetComponentInChildren<Camera>().enabled = true;
	}
}
