using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudio : MonoBehaviour {
    public AudioClip asd;

    public void ClipStart()
    {
        AudioSource.PlayClipAtPoint(asd,transform.position);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
