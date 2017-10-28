using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutEnemy : MonoBehaviour {

    public string enemyName;

    public string objectName;

    public float maxTime = 10.0f;

    public float minTime = 0.0f;

    public GameObject enemy;

    public Transform[] putPoint;


    private int objectCnt;


    // Use this for initialization
    private void Awake()
    {
        string objName;
        objectCnt = this.transform.childCount;
        putPoint = new Transform[objectCnt];
        for(int i = 0; i < objectCnt; i++)
        {
            objName = objectName + " (" + (i + 1) + ")";
            putPoint[i] = GameObject.Find(objName).transform;
        }

    }

    void Start () {
        StartCoroutine(Put(10));
	}
	
    public IEnumerator Put(int maxEnemy)
    {
        int cnt = 0;
        int point;
        float interval;
        GameObject tmp;

        while(cnt <= maxEnemy)
        {
            interval = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(interval);

            point = Random.Range(0, objectCnt);

            tmp = Instantiate(enemy,putPoint[point]);
            tmp.name = enemyName + "_" + cnt;
        }

        Debug.Log("END");
    }
}
