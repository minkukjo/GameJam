using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetKnight : MonoBehaviour {

	private void OnCollisionStay(Collision collision)
	{
        if(collision.transform.tag == "Knight")
        {
            Debug.Log("hi");
        }
	}
}
