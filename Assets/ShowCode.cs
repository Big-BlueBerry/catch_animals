using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCode : MonoBehaviour {
    public Text Scode;
    public int Wtime;
    private float time;
    private Code code;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if(time >= Wtime)
        {
            ShowText();
            time = 0;
        }

	}

    void ShowText()
    {
        code = (Code)Random.Range(0, System.Enum.GetValues(typeof(Code)).Length);
        Scode.text = "이번 코드는~^^" + code;
    }

    public enum Code
    {
        C,
        D,
        E,
        F,
        G,
        A,
        B,
        Cm,
        Dm,
        Em,
        Fm,
        Gm,
        Am,
        Bm
    }
}
