using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        GUI.HorizontalSlider(new Rect(0, 0, 160, 30), 1f,0f,1f);
    }
}
