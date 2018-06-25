using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASTask
{
    public string name;
    public List<ConversationBubData> step1audios;
    public ConversationBubData step2audio;
    public Dictionary<int,ObjectOption> step2data;
    public ConversationBubData step3audio;

}

public class ASGlobal : MonoBehaviour {

    [Header("Object Sprite")]
    public Sprite RAG;
    public Sprite LAMP;
    public Sprite TRASH;
    public Sprite TV;
    public Sprite TELE;
    public Sprite FAN;

    public Dictionary<ObjectOption, Sprite> objectSpriteDict;

	// Use this for initialization
	void Start () {
        taskData = new ASTask();


        objectSpriteDict = new Dictionary<ObjectOption, Sprite>(){
            {ObjectOption.RAG , RAG},
            {ObjectOption.LAMP , LAMP},
            {ObjectOption.TRASH , TRASH},
            {ObjectOption.TV , TV},
            {ObjectOption.TELE , TELE},
            {ObjectOption.FAN , FAN}
        };




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
