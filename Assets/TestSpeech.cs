using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpeech : MonoBehaviour {


    TextToSpeechLib txtspch;
    int txtcounter;
    // Use this for initialization
    void Start()
    {
        Input.simulateMouseWithTouches = true;
        txtspch = new TextToSpeechLib();
        txtcounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (txtcounter == 0)
            {
                txtspch.Convert("Hello! Welcome to our hospital. I will be your guide today.");
            }
            else if (txtcounter == 1)
            {
                txtspch.Convert("You can follow me and I will show you where to go");
            }
            else if (txtcounter == 2)
            {
                txtspch.Convert("Test 2");
            }
            else if (txtcounter == 3)
            {
                txtspch.Convert("Test 3");
            }

            txtcounter++;
        }
    }

}
