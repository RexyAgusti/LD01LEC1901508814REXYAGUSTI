using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapSystem : MonoBehaviour {
	public int check;
	public int curr_check;
	public int no_laps;
	public int curr_lap;
	public GameObject fh_ui;
	// Use this for initialization
	void Start () {
		check = GameObject.Find ("Checkpoints").transform.childCount;
		curr_check = 1;
		no_laps = 3;
		curr_lap = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (curr_check > check) {
			curr_lap++;
			curr_check = 1;
		}
		if(curr_lap > no_laps){
			
			fh_ui.SetActive (true);
		}
	}
	void OnTriggerEnter(Collider check_col){
		if(check_col.name == curr_check.ToString()){
			curr_check++;
		}
	}
}
