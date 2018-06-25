using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASTask
{
    public string name;
    public List<ConversationBubData> step1audios;
    public ConversationBubData step2audio;
    public List<int> step2data;
    public ConversationBubData step3audio;

}

public class ASGlobal : MonoBehaviour {



	// Use this for initialization
	void Start () {
        taskData = new ASTask();
	}
    public ASTask taskData; 
    public static ASGlobal Instance;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }


	// Update is called once per frame
	void Update () {
		
	}


}
