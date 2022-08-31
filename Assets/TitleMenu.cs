using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMenu : MonoBehaviour
{
    [SerializeField] GameObject goStageUI = null;

    public void BtnPlay()
    {
        goStageUI.SetActive(true);
        this.gameObject.SetActive(false);
        AudioManager.instance.PlayBGM("Weekend");
    }
    // Start is called before the first frame update
}
