using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelecter : MonoBehaviour {

    // Use this for initialization

    public static ObjectSelecter Instance;
    public CanvasGroup canvasGroup; 
	private void Awake()
	{
        Instance = this;
        canvasGroup = GetComponent<CanvasGroup>();
        Hide();
	}

    public Action<int> callBackFunc; 
    public void Open (  Action<int> action){
        this.callBackFunc = action;
        Show();
    }

    public void Select (int i) {
        //var c = (Charcter)i;
        Hide();
        if (callBackFunc != null){
            callBackFunc(i);
        }
    }


	public void Hide (){
        canvasGroup.alpha =  0;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false; 
    }
    void Show (){
        canvasGroup.alpha =  1;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true; 
    }
}
