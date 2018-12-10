using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRWallCtrl : MonoBehaviour {
    public GameObject[] LRWall;
    private bool redo = true;

	
	// Update is called once per frame
	void Update () {
        if (redo)
        {
            StartCoroutine(VisibleCtrl());
        }
        
    }

    IEnumerator VisibleCtrl()
    {
        redo = false;
        for(int i=0; i<LRWall.Length; i++)
        {
            LRWall[i].SetActive(false);           
            yield return new WaitForSeconds(1.0f);
            LRWall[i].SetActive(true);
        }
        redo = true;
    }
}
