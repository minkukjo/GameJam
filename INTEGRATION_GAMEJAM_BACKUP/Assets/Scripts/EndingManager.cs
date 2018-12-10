using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingManager : MonoBehaviour {
    public static EndingManager instance;//싱글턴+돈디스트로이
    public List<Vector3> SpotPointList =new List<Vector3>();
    public LineRenderer lineRenderer;//발자취 그려줄 랜더러

    Vector3 Offset = Vector3.zero;

    int SceneIndex = 0;
    int EndSceneIndex = 3; 

    #region SingleToneAwake
    private void Awake()
    {if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        { Debug.LogError("싱글턴 이미 있음!!");
            Destroy(instance);
            instance = this;
    }


    }
    #endregion
 
    public void TestAdd()
    {
        AddSpot(transform.position);
        Debug.Log("현재 좌표 개수:" + SpotPointList.ToArray().Length);
    }

    public void OnSceneChanged()
    {
        Debug.Log("! list last index :" + (SpotPointList.Count - 1).ToString());
        Offset = SpotPointList[SpotPointList.Count - 1];
        Debug.Log("Vec3 Offset:" + Offset);
    }
    public void AddSpot(Vector3 _spot)
    {
        Vector3 temp = _spot + Offset;        
        SpotPointList.Add(temp);
    }

    public void MakeLine()
    {
        lineRenderer.enabled = true;
        lineRenderer.positionCount = SpotPointList.ToArray().Length;
        lineRenderer.SetPositions(SpotPointList.ToArray());
        Debug.Log("현재 라인렌더러 좌표 개수:" + lineRenderer.positionCount);
    }


	private void OnLevelWasLoaded(int level)
    {

       

        SceneIndex++;



        if(SceneIndex ==EndSceneIndex-1)
        {
            MakeLine();
            StartCoroutine(GameEnd());
            SpotPointList.Clear();
            SceneIndex = 0;
            Offset = Vector3.zero;

        }
        Debug.Log("Endmanager Start Test" + SceneIndex);
	}


    public IEnumerator GameEnd()
    {
        yield return new WaitForSeconds(16f);
        SceneManager.LoadScene(0);

    }


}
