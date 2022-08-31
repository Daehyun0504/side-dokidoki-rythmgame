using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineTest : MonoBehaviour
{
    [SerializeField] GameObject[] goGameUI = null;
    [SerializeField] public int[] GoalPosing = null;
    [SerializeField] public int[] GoalTiming = null;

    public int timingRotate = 0;

    MusicStart theMusicStart;


    // Start is called before the first frame update
    void Start()
    {
        theMusicStart = FindObjectOfType<MusicStart>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timingRotate != 5)
        {
            if (GoalTiming[timingRotate] == theMusicStart.BeatTiming)
            {
                for (int i = 0; i <= 1; i++)
                {
                    // 동작구간에 점수 산출하는 부분
                    Debug.Log(goGameUI[i].transform.position.x + " " + goGameUI[i].transform.position.x);
                    // 동작 결과
                    Debug.Log("Good!");
                }
                timingRotate++;
            }
        }
       


    }
}
