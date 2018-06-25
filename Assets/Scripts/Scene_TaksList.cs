using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AudiStory;
public class Scene_TaksList : SceneScriptBase {


    // Use this for initialization


    public Button play_btn;

	void Start () {



        if (ASGlobal.Instance.taskData.step3audio == null ){
            play_btn.gameObject.SetActive(false);
        }else {
            play_btn.gameObject.SetActive(true);
            play_btn.transform.GetComponentInChildren<Text>().text = ASGlobal.Instance.taskData.name;
        }
	}

	// Update is called once per frame
	void Update () {
		
	}

    public void Btn_Create (){
        NextScene("02_SelectScene");
    }
    public void Btn_Play (){
        NextScene("06_TaskCon");
    }

}
