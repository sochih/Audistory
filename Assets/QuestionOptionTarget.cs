using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionOptionTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionStay2D(Collision2D coll)
    {
        Debug.Log("------正在碰撞-------------");
        Debug.Log(coll.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        Debug.Log("------结束碰撞-------------");
        Debug.Log(coll.gameObject.name);
    }

}
