﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using AudiStory; 

//namespace AudiStory {
    
    public class SceneScriptBase : MonoBehaviour {



    	// Use this for initialization
    	void Start () {
    		
    	}

    	// Update is called once per frame
    	void Update () {
    		
    	}
        public void NextScene (string sceneName ){
            SceneManager.LoadScene(sceneName);
        }
    }

//}