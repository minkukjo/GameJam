using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddhaFakeObj : InteractObject {
    public GameObject ceil;

	// Use this for initialization
	void Start () {
		
	}

    public override void InteractAction()
    {
        base.InteractAction();
        ceil.SetActive(true);
    }
}
