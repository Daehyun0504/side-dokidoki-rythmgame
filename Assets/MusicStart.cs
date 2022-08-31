using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    bool musicStart = false;
    public int BeatTiming = 0;
    // Start is called before the first frame update
   

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!musicStart)
        {
            if (collision.CompareTag("Note"))
            {
                AudioManager.instance.PlayBGM("Dream");
                musicStart = true;
            }
        }

        if (collision.CompareTag("Note"))
        {
            BeatTiming++;
            
        }
    }

}
