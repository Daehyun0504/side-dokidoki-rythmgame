using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int a = 1;
    // 테스트 코드

    
    public List<GameObject> boxNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    Vector2[] timingBoxs = null;

    ScoreManager theScoreManager;
    
    void Start()
    {
        timingBoxs = new Vector2[timingRect.Length];
        for(int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.localPosition.x - timingRect[i].rect.width / 2,
                Center.localPosition.x + timingRect[i].rect.width / 2);
        }

        theScoreManager = FindObjectOfType<ScoreManager>();
        
    }
    
    public void CheckTiming()
    {
        
            for (int i = 0; i < boxNoteList.Count; i++)
            {
                float t_notePosX = boxNoteList[i].transform.localPosition.x;

                for (int x = 0; x < timingBoxs.Length; x++)
                {
                    if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                    {
                        boxNoteList[i].GetComponent<Note>().HideNote();
                        boxNoteList.RemoveAt(i);
                        Debug.Log("Hit" + x);


                        // 점수증가
                        theScoreManager.IncreaseScore(x);
                        return;
                    }
                }
            }
            Debug.Log("Miss");
        
        
    }

    


}
