using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giphy : MonoBehaviour {

    public StageManager stg;
    public GameObject game_2D;

	// Use this for initialization
	void Start () {
        Invoke("back", 5);
	}

    public void back()
    {
        game_2D.SetActive(false);
        stg.Player.SetActive(true);
    }



}
