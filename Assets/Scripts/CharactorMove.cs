using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;




public enum Side
{
    LEFT = 0,
    RIGHT = 1
}

public class CharactorMove : MonoBehaviour
{

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

    public LTDescr ShowAnim(GameObject g, Side s)
    {

        Debug.Log("g" + g);
        Debug.Log("ss" + stopPositionL);
        if (s == Side.LEFT)
        {
            return LeanTween.move(g, stopPositionL, 2f).setEase(LeanTweenType.easeOutQuad);
        }
        else
        {
            return LeanTween.move(g, stopPositionR, 2f).setEase(LeanTweenType.easeOutQuad);
        }

    }


    public LTDescr HideAnim(GameObject g, Side s)
    {

        Debug.Log("g" + g);
        Debug.Log("ss" + stopPositionL);
        if (s == Side.LEFT)
        {
            return LeanTween.move(g, startPositionL, 2f).setEase(LeanTweenType.easeOutQuad);
        }
        else
        {
            return LeanTween.move(g, startPositionR, 2f).setEase(LeanTweenType.easeOutQuad);
        }

    }


    public LTDescr HideCharacter(Character cc, Side ss)
    {



        var L = Side.LEFT;
        var R = Side.RIGHT;
        int c = (int)cc;
        int s = (int)ss;
        if (c == 0 && s == 0)
        {
            return HideAnim(dadL, L);
        }

        else if (c == 0 && s == 1)
        {
            return HideAnim(dadR, R);
        }

        else if (c == 1 && s == 0)
        {
            return HideAnim(momL, L);
        }

        else if (c == 1 && s == 1)
        {
            return HideAnim(momR, R);
        }

        else if (c == 2 && s == 0)
        {
            return HideAnim(broL, L);
        }

        else if (c == 2 && s == 1)
        {
            return HideAnim(broR, R);
        }

        else if (c == 3 && s == 0)
        {
            return HideAnim(sisL, L);
        }

        else if (c == 3 && s == 1)
        {
            return HideAnim(sisR, R);
        }

        else if (c == 4 && s == 0)
        {
            return HideAnim(grandmaL, L);
        }

        else
        {
            return HideAnim(grandmaR, R);
        }
    }


    public LTDescr ShowCharacter(Character cc, Side ss)
    {



        var L = Side.LEFT;
        var R = Side.RIGHT;
        int c = (int)cc;
        int s = (int)ss;
        if (c == 0 && s == 0)
        {
            return ShowAnim(dadL, L);
        }

        else if (c == 0 && s == 1)
        {
            return ShowAnim(dadR, R);
        }

        else if (c == 1 && s == 0)
        {
            return ShowAnim(momL, L);
        }

        else if (c == 1 && s == 1)
        {
            return ShowAnim(momR, R);
        }

        else if (c == 2 && s == 0)
        {
            return ShowAnim(broL, L);
        }

        else if (c == 2 && s == 1)
        {
            return ShowAnim(broR, R);
        }

        else if (c == 3 && s == 0)
        {
            return ShowAnim(sisL, L);
        }

        else if (c == 3 && s == 1)
        {
            return ShowAnim(sisR, R);
        }

        else if (c == 4 && s == 0)
        {
            return ShowAnim(grandmaL, L);
        }

        else
        {
            return ShowAnim(grandmaR, R);
        }
    }

    // Use this for initialization
    void Start()
    {
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

        //ShowCharacter(Character.FATHER, Side.LEFT);
        //StartCoroutine(test());
    }

    IEnumerator test()
    {
        yield return new WaitForSeconds(5f);
        HideCharacter(Character.FATHER, Side.LEFT);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
