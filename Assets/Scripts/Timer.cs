using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static float time;

	// Use this for initialization
	void Start () {
		time = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Goal.goal == false) {
			time += Time.deltaTime;
		}

		int timeSec = Mathf.FloorToInt (time);
		Text timerText = GetComponent<Text> ();
		timerText.text = "Time:" + timeSec;
	}
}
