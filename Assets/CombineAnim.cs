using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineAnim : MonoBehaviour
{
    [SerializeField] GameObject[] goGameUI = null;
    [SerializeField] public int[] GoalPosing = null;
    [SerializeField] public int[] GoalTiming = null;

    public int timingRotate = 0;
    public float result = 0;

    MusicStart theMusicStart;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        theMusicStart = FindObjectOfType<MusicStart>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timingRotate != 3)
        {
            if (GoalTiming[timingRotate] == theMusicStart.BeatTiming)
            {
                for (int i = 0; i <= 0; i++)
                {
                    result = Mathf.Round(goGameUI[i].transform.position.x*1000);
                }
                if (result == GoalPosing[timingRotate]) Debug.Log("Good");
                else Debug.Log("Bad");
                timingRotate++;
            }
        }




        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetInteger("Change", 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetInteger("Change", 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetInteger("Change", 2);
        }
    }
}
