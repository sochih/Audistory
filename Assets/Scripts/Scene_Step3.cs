using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Step3 : SceneScriptBase {

    // Use this for initialization

    public ConversationBubUI bubUI;

	void Start () {
        bubUI.Init();
	}

	// Update is called once per frame
	void Update () {
		
	}

    public void Save (){
        ASGlobal.Instance.taskData.step3audio = bubUI.conversationBub;
        NextScene("01_TaskList");
    }
}
