using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SmallManFsm : MonoBehaviour {
    public bool isChaser = false;
    NavMeshAgent nav;
  

    GameObject _player;
    States _States;
    Animator anim;
 Vector3 Dest;
    public float dist = 5f;
    private void Start()
    {
        anim = GetComponent<Animator>();
           nav = GetComponent<NavMeshAgent>();
        _player = StageManager.instance.Player;

        StartCoroutine(StateLoop());
        StartCoroutine(ActionLoop());
    }
    IEnumerator StateLoop()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.7f);
            if(Vector3.Distance(transform.position, _player.transform.position) <= dist && !isChaser)
            {
                _States = States.Escape;
            }

            else if (Vector3.Distance(transform.position, _player.transform.position) <= dist && isChaser)
            {
                _States = States.Chase;
            }
            else
            {
                _States = States.Idle;
            }
        }
    }
    IEnumerator ActionLoop()
    {
        while (true)
        {
            Animating();
               yield return null;
            switch(_States)
            {
                case States.Idle:
                    Vector3 newRandPos = new Vector3(transform.position.x + Random.Range(-3f, 3f), 0, transform.position.z + Random.Range(-3f, 3f));
                    nav.SetDestination(newRandPos);
                    break;
                case States.Chase:
                    nav.SetDestination(_player.transform.position);
                    break;
                case States.Escape:

                   // float distPlayer = Vector3.Distance(transform.position, _player.transform.position);
                    Vector3 EsDir = transform.position - _player.transform.position;
                    EsDir.y = 0f;
                    EsDir=EsDir.normalized;
                    Dest = EsDir * 15f;
                    nav.SetDestination(Dest);

                    break;
            }

        }
    }
    void Animating()
    {
        anim.SetFloat("Speed", nav.velocity.magnitude / nav.speed);
    }

}
public enum States { Idle,Escape,Chase}