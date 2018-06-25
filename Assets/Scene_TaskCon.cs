using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_TaskCon : SceneScriptBase {

    // Use this for initialization

    public AudioSource audioSource;
    public CharactorMove charactorMove;
	void Start () {
        charactorMove = GetComponent<CharactorMove>();
        var s = LeanTween.sequence();

        int i = 0; 
        foreach (var c in ASGlobal.Instance.taskData.step1audios){

            Side side = (Side)(i % 2);
            i++;
            s.append(charactorMove.ShowCharacter(c.character,side));

            s.append(() =>
            {
                audioSource.clip = c.audioRecorder.audio;
                audioSource.Play();
            });
            s.append(c.audioRecorder.audio.length);

            s.append(charactorMove.HideCharacter(c.character,side));

        }
        s.append(() =>
        {
            NextScene("07_TaskQuestion");
        });

        //s.append()

        //s.append();

	}

	// Update is called once per frame
	void Update () {
		
	}
}
