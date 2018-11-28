using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    //씬전환
    //public void ChangeGameScene()
    //{
    //    SceneManager.LoadScene ("GameLogin");
    //}

        

    //2개의 장면 씬전환   ->  이후에 Crtl Shift B 빌드에 각씬올리기 

    public void NextButtonClick()
    {
        SceneManager.LoadScene ("GameLogin");
    }
    public void StartButtonClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
