using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2DPlayer : MonoBehaviour {

    public float Speed = 10.0f;
    public Animator anim;
    public StageManager stg;
    public GameObject game_2D;
	// Use this for initialization
	void Start () {
        anim = transform.GetComponent<Animator>();
        Invoke("back", 5);
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
        anim.Play("Run");
    }

    public void back()
    {
        game_2D.SetActive(false);
        stg.Player.SetActive(true);
    }


}
