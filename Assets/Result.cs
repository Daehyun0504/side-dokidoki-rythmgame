using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] GameObject goUI = null;
    [SerializeField] Text txtCoin = null;

    ScoreManager theScore;

    // Start is called before the first frame update
    void Start()
    {
        theScore = FindObjectOfType<ScoreManager>();
        goUI.SetActive(false);
    }

    private void Update()
    {
        int t_currentScore = theScore.GetCurrentScore();
        if (t_currentScore > 100)
        {
            goUI.SetActive(true);
            txtCoin.text = "Clear";
        }
    }

}
