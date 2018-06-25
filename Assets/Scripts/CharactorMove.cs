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

    void ShowAnim(GameObject g, Side s)
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


    void HideAnim(GameObject g, Side s)
    {

        Debug.Log("g" + g);
        Debug.Log("ss" + stopPositionL);
        if (s == Side.LEFT)
        {
            LeanTween.move(g, startPositionL, 2f).setEase(LeanTweenType.easeOutQuad);
        }
        else
        {
            LeanTween.move(g, startPositionR, 2f).setEase(LeanTweenType.easeOutQuad);
        }

    }


    void HideCharacter(Character cc, Side ss)
    {



        var L = Side.LEFT;
        var R = Side.RIGHT;
        int c = (int)cc;
        int s = (int)ss;
        if (c == 0 && s == 0)
        {
            HideAnim(dadL, L);
        }

        else if (c == 0 && s == 1)
        {
            HideAnim(dadR, R);
        }

        else if (c == 1 && s == 0)
        {
            HideAnim(momL, L);
        }

        else if (c == 1 && s == 1)
        {
            HideAnim(momR, R);
        }

        else if (c == 2 && s == 0)
        {
            HideAnim(broL, L);
        }

        else if (c == 2 && s == 1)
        {
            HideAnim(broR, R);
        }

        else if (c == 3 && s == 0)
        {
            HideAnim(sisL, L);
        }

        else if (c == 3 && s == 1)
        {
            HideAnim(sisR, R);
        }

        else if (c == 4 && s == 0)
        {
            HideAnim(grandmaL, L);
        }

        else
        {
            HideAnim(grandmaR, R);
        }
    }


    void ShowCharacter(Character cc, Side ss){



		var L = Side.LEFT ;
		var R = Side.RIGHT ; 
		int c = (int)cc ;
		int s = (int)ss ; 
		if (c == 0 && s == 0)
		{
			ShowAnim(dadL, L);
		}
	
		else if (c == 0 && s == 1)
		{
			ShowAnim(dadR,R);
		}
		
		else if (c == 1 && s == 0)
		{
			ShowAnim(momL,L);
		}
		
		else if (c == 1 && s == 1)
		{
			ShowAnim(momR,R);
		}
		
		else if (c == 2 && s == 0)
		{
			ShowAnim(broL,L);
		}
		
		else if (c == 2 && s == 1)
		{
			ShowAnim(broR,R);
		}
		
		else if (c == 3 && s == 0)
		{
			ShowAnim(sisL,L);
		}
		
		else if (c == 3 && s == 1)
		{
			ShowAnim(sisR,R);
		}
		
		else if (c == 4 && s == 0)
		{
			ShowAnim(grandmaL,L);
		}
		
		else
		{
			ShowAnim(grandmaR,R);
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
		
        ShowCharacter(Character.FATHER, Side.LEFT);
        StartCoroutine(test());
	}

    IEnumerator test () 
        {
            yield return new WaitForSeconds(5f);
            HideCharacter(Character.FATHER, Side.LEFT);
        }

	
	// Update is called once per frame
	void Update () {
		
	}
}
