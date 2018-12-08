using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mamison : InteractObject
{
    public AudioSource mamison_sound;

	public override void InteractAction()
	{
        base.InteractAction();
        mamison_sound = GetComponent<AudioSource>();
        mamison_sound.Play();
	}
}
