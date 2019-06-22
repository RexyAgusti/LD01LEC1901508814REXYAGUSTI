using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

	// Use this for initialization

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	void OnTriggerEnter(){
		LapCompleteTrig.SetActive (true);
		HalfLapTrig.SetActive (false);

	}
}
