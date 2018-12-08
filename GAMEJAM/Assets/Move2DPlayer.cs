using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2DPlayer : MonoBehaviour {

    public float Speed = 10.0f;
    public Animator anim;
	// Use this for initialization
	void Start () {
        anim = transform.GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
        anim.Play("Run");
        Invoke("move_turn", 3);
    }

    void move_turn()
    {
        
    }
}
