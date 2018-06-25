using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene_TaskQuestion : SceneScriptBase {

    // Use this for initialization
    [SerializeField] public List<Image> options;
    public AudioSource audioSource;
    public AudioClip Testaudio; 
    void Start()
    {
        Test();
        for (int i = 0; i < options.Count; i++)
        {
            Image temp = options[i];
            int randomIndex = Random.Range(i, options.Count);
            options[i] = options[randomIndex];
            options[randomIndex] = temp;
        }
        audioSource.clip = Testaudio;
        audioSource.Play();
        //audioSource.clip = ASGlobal.Instance.taskData.step2audio.audioRecorder.audio;

        for (int j = 0; j < 4; j++){
            var k = ASGlobal.Instance.taskData.step2data[j];
            options[j].sprite = ASGlobal.Instance.objectSpriteDict[k];
            options[j].name = j.ToString();
        }

	}

    public void Select ( GameObject g ){
        if (g.name.Equals("0") ){
            NextScene("08_TaskEnding");
        }else {
            WrongFeedBack.Instance.Open();


        }
    }

	// Update is called once per frame
	void Update () {
		
	}

    void Test (){
        ASGlobal.Instance.taskData.step2data = new Dictionary<int, ObjectOption>(){
            {1,ObjectOption.TV},
            {0,ObjectOption.LAMP},
            {2,ObjectOption.RAG},
            {3,ObjectOption.TELE}
        };
    }

    public void Back(){
        NextScene("06_TaskCon");
    }
    public void Leave (){
        NextScene("01_TaskList");
    }
}
