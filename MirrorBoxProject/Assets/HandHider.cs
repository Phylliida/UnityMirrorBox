using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHider : MonoBehaviour {

    public Transform[] handsToHide;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Transform handToHide in handsToHide)
        {
		    foreach (Renderer renderer in handToHide.GetComponentsInChildren<Renderer>())
            {
                renderer.enabled = false;
            }
        }
    }
}
