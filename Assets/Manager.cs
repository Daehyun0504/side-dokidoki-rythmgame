using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject goNote = null;

    TimingManager theTimingManager;
    
    void Start()
    {
        theTimingManager = GetComponent<TimingManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isStartGame)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= 60d / bpm)
            {
                // 오브젝트 풀의 잔해들
                //    GameObject t_note = ObjectPool.instance.noteQueue.Dequeue();
                //    t_note.transform.position = tfNoteAppear.position;
                //    t_note.SetActive(true);
                GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
                t_note.transform.SetParent(this.transform); 
                theTimingManager.boxNoteList.Add(t_note);
                currentTime -= 60d / bpm;
            }
        }

       
    }

    private void OnTriggerExit2D(Collider2D collision)  
    {
        if (collision.CompareTag("Note"))
        {
            

            theTimingManager.boxNoteList.Remove(collision.gameObject);
            // 오브젝트 풀의 잔해들
        //    ObjectPool.instance.noteQueue.Enqueue(collision.gameObject);
        //    collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
