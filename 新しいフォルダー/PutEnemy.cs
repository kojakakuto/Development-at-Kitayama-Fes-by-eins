using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutEnemy : MonoBehaviour {

    public string enemyTag;

    public string enemyName;

    public string objectName;

    public float maxTime = 10.0f;

    public float minTime = 0.0f;

    public GameObject enemy;

    public Transform[] putPoint;

    private hpBrakeCheck hpBC;

    private int objectCnt;

    private bool resultFlg;

    public int lastCnt = 10;

    public float lastDistance = 1.0f;

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
        hpBC = GameObject.Find("House").GetComponent<hpBrakeCheck>();

        resultFlg = false;
    }
	
    public IEnumerator Put(int maxEnemy)
    {
        int cnt = 0;
        int point;
        float interval;
        float inMaxTime = maxTime;
        GameObject tmp;
        bool flg = false;

        while(cnt < maxEnemy)
        {
            interval = Random.Range(minTime, inMaxTime);
            if (hpBC.checkEnd())
            {
                break; //オブジェクトが破壊されていれば終了する
            }
            yield return new WaitForSeconds(interval);


            point = Random.Range(0, objectCnt);

            tmp = Instantiate(enemy,putPoint[point].position,new Quaternion(),putPoint[point]);
            tmp.name = enemyName + "_" + cnt++;
            if(maxEnemy-cnt > 10)
            {
                inMaxTime -= 0.2f;
            }
            else if(!flg)
            {
                inMaxTime = lastDistance;
            }
        }


        while ( GameObject.FindGameObjectsWithTag(enemyTag).Length > 0)

        {
            yield return new WaitForSeconds(1);
        }

        if (hpBC.checkEnd())
        {
            resultFlg = true;
        }
        else
        {
            Debug.Log("CLEAR");
        }
    }

    public int ShowCastleHP()
    {
        return hpBC.ShowCastleHP();
    }
    public bool ShowResult()
    {
        return !resultFlg;
    }
}
