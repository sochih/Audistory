using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlay : MonoBehaviour {

    // Use this for initialization

    public AudioClip c1;
    public AudioClip c2;
    public AudioClip q;
    public AudioClip fb;

	void Start () {

        ASGlobal.Instance.taskData.name = "tesrt";

        ASGlobal.Instance.taskData.step1audios = new List<ConversationBubData>();

        ASGlobal.Instance.taskData.step1audios.Add(new ConversationBubData());
        ASGlobal.Instance.taskData.step1audios[0].audioRecorder = new AudioRecorder();
        ASGlobal.Instance.taskData.step1audios[0].character = Character.BROTHER;
        ASGlobal.Instance.taskData.step1audios[0].audioRecorder.audio = c1;

        ASGlobal.Instance.taskData.step1audios.Add(new ConversationBubData());
        ASGlobal.Instance.taskData.step1audios[1].audioRecorder = new AudioRecorder();
        ASGlobal.Instance.taskData.step1audios[1].character = Character.GRANDMA;
        ASGlobal.Instance.taskData.step1audios[1].audioRecorder.audio = c2;

        ASGlobal.Instance.taskData.step1audios.Add(new ConversationBubData());
        ASGlobal.Instance.taskData.step1audios[2].audioRecorder = new AudioRecorder();
        ASGlobal.Instance.taskData.step1audios[2].character = Character.BROTHER;
        ASGlobal.Instance.taskData.step1audios[2].audioRecorder.audio = c1;

        var a = ASGlobal.Instance.taskData;
        a.step2audio = new ConversationBubData();
        a.step2audio.audioRecorder = new AudioRecorder();
        a.step2audio.audioRecorder.audio = q;

        ASGlobal.Instance.taskData.step2data = new Dictionary<int, ObjectOption>(){
            {1,ObjectOption.TV},
            {0,ObjectOption.LAMP},
            {2,ObjectOption.RAG},
            {3,ObjectOption.TELE}
        };
        a.step3audio = new ConversationBubData();
        a.step3audio.audioRecorder = new AudioRecorder();
        a.step3audio.audioRecorder.audio = fb;


	}

	// Update is called once per frame
	void Update () {
		
	}
}
