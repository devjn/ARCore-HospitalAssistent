using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpeech : MonoBehaviour {

	TextToSpeechLib txtspch;
	// Use this for initialization
	void Start () {
		txtspch = new TextToSpeechLib ();
		txtspch.Convert ("Hello! Welcome to our hospital. I will be your guide today.");
	}
	
	// Update is called once per frame
	void Update () {


	}
}
