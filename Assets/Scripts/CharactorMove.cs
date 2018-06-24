using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;




public enum Side
{
	LEFT = 0,
	RIGHT = 1
}

public class CharactorMove : MonoBehaviour {

public Transform startPositionL;
public Transform stopPositionL;
public Transform startPositionR;
public Transform stopPositionR;

GameObject momR;
GameObject dadR;
GameObject sisR;
GameObject broR;
GameObject grandmaR;
GameObject momL;
GameObject dadL;
GameObject sisL;
GameObject broL;
GameObject grandmaL;

void MoveAnimation(GameObject g, Side s)
{	
    Debug.Log ("g" + g);
    Debug.Log ("ss" + stopPositionL);
    if (s == Side.LEFT )
	{
	LeanTween.move(g, stopPositionL, 2f).setEase(LeanTweenType.easeOutQuad);
	}
	else
	{
	LeanTween.move(g, stopPositionR, 2f).setEase(LeanTweenType.easeOutQuad);
	}
}


void DecideCharacter(Character cc, Side ss){
		var L = Side.LEFT ;
		var R = Side.RIGHT ; 
		int c = (int)cc ;
		int s = (int)ss ; 
		if (c == 0 && s == 0)
		{
			MoveAnimation(dadL, L);
		}
	
		else if (c == 0 && s == 1)
		{
			MoveAnimation(dadR,R);
		}
		
		else if (c == 1 && s == 0)
		{
			MoveAnimation(momL,L);
		}
		
		else if (c == 1 && s == 1)
		{
			MoveAnimation(momR,R);
		}
		
		else if (c == 2 && s == 0)
		{
			MoveAnimation(broL,L);
		}
		
		else if (c == 2 && s == 1)
		{
			MoveAnimation(broR,R);
		}
		
		else if (c == 3 && s == 0)
		{
			MoveAnimation(sisL,L);
		}
		
		else if (c == 3 && s == 1)
		{
			MoveAnimation(sisR,R);
		}
		
		else if (c == 4 && s == 0)
		{
			MoveAnimation(grandmaL,L);
		}
		
		else
		{
			MoveAnimation(grandmaR,R);
		}	
}

	// Use this for initialization
	void Start () {
		momR = GameObject.Find("MomR");
		dadR = GameObject.Find("DadR");
		sisR = GameObject.Find("SisR");
		broR = GameObject.Find("BroR");
		grandmaR = GameObject.Find("GrandmaR");
		momL = GameObject.Find("MomL");
		dadL = GameObject.Find("DadL");
		sisL = GameObject.Find("SisL");
		broL = GameObject.Find("BroL");
		grandmaL = GameObject.Find("GrandmaL");
		
		DecideCharacter(Character.FATHER, Side.LEFT);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
