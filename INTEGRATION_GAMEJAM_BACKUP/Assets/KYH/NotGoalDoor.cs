using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGoalDoor : InteractObject {
    public GameObject laughMan;
    public AudioSource laughManSound;

    public override void InteractAction()
    {
        base.InteractAction();
        laughMan.SetActive(true);
        Destroy(this.gameObject);
        laughManSound.Play();
    }
}
