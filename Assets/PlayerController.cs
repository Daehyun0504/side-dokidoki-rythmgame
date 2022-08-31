using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    TimingManager theTimingManager;

    void Start()
    {
        theTimingManager = FindObjectOfType<TimingManager>();
    }

    // Update is called once per frame
    void Update()
    {
    //    Debug.Log(GameManager.instance.isStartGame);
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            theTimingManager.CheckTiming();
         // 테스트코드
         // Debug.Log(theTimingManager.a);
            /*
            if (GameManager.instance.isStartGame)
            {
                Debug.Log(theTimingManager.a);
            } 
            */
        }
    }
}
