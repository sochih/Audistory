using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudiStory;



public class Scene_Step1 : SceneScriptBase {


    public GameObject conversationSqure_con;

    public GameObject conversationSqure_template;

    public Transform createBtn;





	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
	
	}

    public void createConversationBub (){
        var g = Instantiate<GameObject>(conversationSqure_template,conversationSqure_con.transform);
        g.GetComponent<ConversationBubUI>().Init();
        createBtn.SetAsLastSibling();
    }

    public void Save (){
        List<ConversationBubData> data = new List<ConversationBubData>(); 
        foreach (var b in  conversationSqure_con.GetComponentsInChildren<ConversationBubUI>() ) {
            data.Add(b.conversationBub);
        }
        ASGlobal.Instance.taskData.step1audios = data; 
    }

}
