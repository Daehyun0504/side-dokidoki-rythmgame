using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
}

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] Sound[] bgm = null;
    [SerializeField] AudioSource bgmPlayer;
    // Start is called before the first frame update

    private void Start()
    {
        instance = this;
    }

    public void PlayBGM(string p_bgmName)
    {
        for(int i = 0; i < bgm.Length; i++)
        {
            if(p_bgmName == bgm[i].name)
            {   
                bgmPlayer.clip = bgm[i].clip; 
                bgmPlayer.Play();
            }
        }
        
    }

    public void StopBGM()
    {
        bgmPlayer.Stop();
    }
}
