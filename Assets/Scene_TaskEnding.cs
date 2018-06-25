using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_TaskEnding : SceneScriptBase {

    // Use this for initialization

    public AudioClip testAudio;
	void Start () {
        var player = GetComponent<AudioSource>(); 
        //player.clip = testAudio;
        player.clip = ASGlobal.Instance.taskData.step3audio.audioRecorder.audio;
        player.Play();
        var s = LeanTween.sequence();
        s.append(player.clip.length + 2);
        s.append(() =>
        {
            NextScene("01_TaskList");
        });
	}

	// Update is called once per frame
	void Update () {
		
	}
}
