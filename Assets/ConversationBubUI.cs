using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum Character
{
    FATHER = 0,
    MOTHER = 1,
    BROTHER = 2,
    SISTER = 3,
    GRANDMA = 4

}

public class AudioRecorder
{
    public string name;
    public AudioClip audio;
}

public class ConversationBub
{
    public Character character;
    public AudioRecorder audioRecorder;
    public ConversationBub () {
        character = Character.MOTHER;
        audioRecorder = null;
    }


}

public class ConversationBubUI : MonoBehaviour
{



    // Use this for initialization

    bool isRecording = false;

    //public

    public Image main_record_img_btn; 
    public Sprite record_btn ;
    public Sprite stop_btn ;
    public Sprite rerecord_btn;
    public ConversationBub conversationBub;


    void Start()
    {
        conversationBub = new ConversationBub();



    }

    //public toggleBtnImg (){
        
    //}

	// Update is called once per frame
	void Update () {
		
	}
}
