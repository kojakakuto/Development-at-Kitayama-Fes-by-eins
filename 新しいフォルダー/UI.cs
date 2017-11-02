using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    private GameObject resultImage;

    private Text resultText;

    private string putTextString;

    public string winString = "おめでとう！";

    public string loseString = "お疲れ様！";

    public string titleName;

    private bool backTitle;

    private Text hpText;

	// Use this for initialization
	void Awake () {
        
        resultImage = GameObject.Find("ResultBackGround");
        resultText = GameObject.Find("Result").GetComponent<Text>();
        backTitle = false;
	}

    void Start()
    {
        resultImage.SetActive(false);
    }
	
    public void ShowResult(bool gameClear,int score, int castleHP,int lot)
    {
        int lastScore = score + castleHP +lot;

        resultImage.SetActive(true);
        
        putTextString = "Score: " + lastScore.ToString() + "\n";
        
        if (gameClear)
        {
            putTextString += winString;
        }
        else
        {
            putTextString += loseString;
        }

        resultText.text = putTextString;

        backTitle = true;
    }

    void Update()
    {
        if (backTitle && Input.anyKeyDown)
        {
            Application.LoadLevel(titleName);
        }
    }
}
