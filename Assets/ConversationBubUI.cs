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

public class ConversationBubData
{
    public Character character;
    public AudioRecorder audioRecorder;
    public ConversationBubData () {
        character = Character.MOTHER;
        audioRecorder = null;
    }
}



public class ConversationBubUI : MonoBehaviour
{

    protected bool isPlaying = false;

    // Use this for initialization

    protected bool isRecording = false;

    protected bool isInited = false;
    //public

    public Image main_record_img_btn; 
    public Sprite record_btn ;
    public Sprite stop_btn ;
    public Sprite rerecord_btn;
    public ConversationBubData conversationBub;
    public Text info_txt; 
    [HideInInspector]
    public AudioSource audioSource;


	void Start()
	{
        audioSource = GetComponent<AudioSource>(); 
	}

    public void Init(ConversationBubData conversationBub = null ){
        isInited = true; 
        this.conversationBub = conversationBub;
        if (this.conversationBub == null)
            this.conversationBub = new ConversationBubData();
    }
        
        

    //public toggleBtnImg (){
        
    //}

	// Update is called once per frame


    public float recordDuration  ;
    public float playDuration;


	private void Update()
	{
        if (!isInited)
        {
            return;
        }
        //Debug.Log("ConversationBubUI update");


        UpdateRecorderUI(); 
	}

    public void UpdateRecorderUI () {
		

        if (isRecording){
            main_record_img_btn.sprite = stop_btn; 
            recordDuration += Time.deltaTime;


            main_record_img_btn.sprite = stop_btn;
            info_txt.text = "錄音中 ... 已錄 " + recordDuration.ToString("0.0") + " 秒";
        }else if (isPlaying ){
            playDuration += Time.deltaTime; 
            info_txt.text = "播放中 ... 已播 " +  playDuration.ToString("0.0") + " 秒，共 " + conversationBub.audioRecorder.audio.length.ToString("0.0") +" 秒";

        }else {
            
            if (conversationBub.audioRecorder == null){
                main_record_img_btn.sprite = record_btn; 
                info_txt.text = "請錄製";
            }else {
                
                main_record_img_btn.sprite = rerecord_btn; 
                info_txt.text = "錄製完成。長度 " + conversationBub.audioRecorder.audio.length.ToString("0.0") + "秒";
            }
        }

	}

    public void Btn_record (){
        if (isPlaying){
            Debug.Log("目前正在播放，不能錄音");
            return;
        }

        if (isRecording){
            recordDuration = 0f;
            isRecording = false;
            string filename = System.Guid.NewGuid().ToString();
            RARE.Instance.StopMicRecording(filename,(AudioClip audio, string name) => {
                conversationBub.audioRecorder = new AudioRecorder() { audio = audio, name = name };
            });
        }else {
            isRecording = true;
            RARE.Instance.StartMicRecording();
        }

    }





	public void Btn_play (){
        if (isPlaying ){
            Debug.Log("目前已經在播放");
            return;
        }

        if ( conversationBub.audioRecorder.audio != null){
            var a = conversationBub.audioRecorder.audio;
            audioSource.clip = a;
            audioSource.Play();

            isPlaying = true ;
            StartCoroutine(resetPlayingStatus(a.length));
        }else {
            Debug.Log("目前沒有錄音檔");
        }
    }

    IEnumerator resetPlayingStatus (float dur ){
        yield return new WaitForSeconds(dur);
        isPlaying = false ; 
    }


    public void CallDestroy (){
        Destroy(gameObject);
    }

}
