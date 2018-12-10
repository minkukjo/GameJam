using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMove : MonoBehaviour {

    public float Speed = 1.0f;
    public Animator anim;
    public GameObject e_knight;
    public bool on_event = false;
    public StageManager stg;
    public GameObject game_2D;


    // Use this for initialization
    void Start()
    {
        anim = transform.GetComponent<Animator>();
        Invoke("Kinght_on", 6);

    }

    public void Kinght_on()
    {
        e_knight.SetActive(true);
        on_event = true;
        Invoke("back", 1);
    }

    public void back()
    {
        game_2D.SetActive(false);
        stg.Player.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        if(Input.GetKey(KeyCode.LeftArrow) && on_event == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * Speed);
            transform.localScale = new Vector3(-1, 1, 1);
            anim.Play("Walk");
        }
        else if(Input.GetKey(KeyCode.RightArrow) && on_event == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
            transform.localScale = new Vector3(1, 1, 1);
            anim.Play("Walk");
        }
        else
        {
            anim.Play("Idle");
        }
    }
}
