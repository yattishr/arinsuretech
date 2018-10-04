using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : DefaultTrackableEventHandler {

    public string gadgetType;

	// Use this for initialization
    protected override void OnTrackingFound () {
        base.OnTrackingFound();
        //Debug.Log(gadgetType);
        Debug.Log(tag);
        // var r = new root();
        // r.CreateQuote(gadgetType);
        // Debug.Log(r.text_mesh.text);
	}

    // Update is called once per frame
    void Update () {
		
	}
}
