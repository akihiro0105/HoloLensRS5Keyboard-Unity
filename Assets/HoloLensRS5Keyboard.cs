using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class HoloLensRS5Keyboard : MonoBehaviour {
    public Text textview;
    private TouchScreenKeyboard keyboard = null;

    // Use this for initialization
    void Start () {
        var gesture = new GestureRecognizer();
        gesture.Tapped += (obj) =>
        {
            if (keyboard == null) keyboard = TouchScreenKeyboard.Open(string.Empty);
            else keyboard.active = true;
        };
        gesture.StartCapturingGestures();
    }
	
	// Update is called once per frame
	void Update () {
        if (keyboard != null) textview.text = keyboard.text;
    }
}
