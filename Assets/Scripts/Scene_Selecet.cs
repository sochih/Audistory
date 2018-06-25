using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using AudiStory;

public class Scene_Selecet : SceneScriptBase {

    // Use this for initialization



    public InputField taskNameInputField;
    public Button nextSceneBtn; 

	void Start () {
        OnValueChange(taskNameInputField.text);
	}

	// Update is called once per frame
	void Update () {

	}

    public void Btn_NextScene (){
        
        ASGlobal.Instance.taskData.name = taskNameInputField.text;
        NextScene("03_Step1");

    }
    public void OnValueChange (string val ){
        bool valid = val.Length > 0;
        Debug.Log(val);
        if (nextSceneBtn.interactable != valid ){
            nextSceneBtn.interactable = valid;
        }
    }
}
