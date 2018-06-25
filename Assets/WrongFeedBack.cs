using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongFeedBack : MonoBehaviour {

    public static WrongFeedBack Instance;
    // Use this for initialization
    public AudioSource audio;
    public CanvasGroup canvas;
	void Start () {


        Instance = this;
	}

	// Update is called once per frame
	void Update () {
		
	}
    public void Open (){
        var s = LeanTween.sequence();
        canvas.alpha = 1;
        canvas.blocksRaycasts = true;
        canvas.interactable = true;

        s.append(audio.clip.length);
        audio.Play();
        s.append(() =>
        {
            canvas.alpha = 0;
            canvas.blocksRaycasts = false; 
            canvas.interactable = false;
        });
    }

}
