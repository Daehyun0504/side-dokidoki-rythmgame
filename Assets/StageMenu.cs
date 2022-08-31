using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMenu : MonoBehaviour
{
    [SerializeField] GameObject TitleMenu = null;

    public void BtnBack()
    {
        TitleMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update

    public void BtnPlay()
    {
        GameManager.instance.GameStart();
        this.gameObject.SetActive(false);
    }
   
}
