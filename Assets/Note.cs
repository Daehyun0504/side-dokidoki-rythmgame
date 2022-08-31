using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float noteSpeed = 400;

    UnityEngine.UI.Image noteImage;

    private void Start()
    {
        noteImage = GetComponent<UnityEngine.UI.Image>();
    }

    /* 오브젝트 풀의 잔해들
    void OnEnable() 
    {
        if (noteImage == null)
            noteImage = GetComponent<UnityEngine.UI.Image>();

        noteImage.enabled = true;
    }
    */

    public void HideNote()
    {
        noteImage.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.right * noteSpeed * Time.deltaTime;
    }


}
