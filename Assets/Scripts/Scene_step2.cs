using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Scene_step2 : SceneScriptBase {

    public ConversationBubUI conversationBubUI;
    public Transform OptionUIContainer; 

	// Use this for initialization
	void Start () {

        conversationBubUI.Init();
		
	}
	
	// Update is called once per frame
	void Update () {
        


	}

    public void Save (){
        var uis = OptionUIContainer.GetComponentsInChildren<OptionSelectUI>();

        ASGlobal.Instance.taskData.step2audio = conversationBubUI.conversationBub;
        ASGlobal.Instance.taskData.step2data = new Dictionary<int, ObjectOption>();
        foreach (var o in uis) {
            if (!o.isSet){
                return; 
            }
            ASGlobal.Instance.taskData.step2data.Add(o.index, o.option);
        }
        NextScene("05_Step3");
    }
}
