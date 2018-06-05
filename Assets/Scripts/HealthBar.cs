using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider healthbar;
	void Start ()
    {
        healthbar.value = 1;
	}
	void Update ()
    {
        transform.LookAt(Camera.main.transform.position);
        healthbar.value -= 0.0005f;
	}
}
