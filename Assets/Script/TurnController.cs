using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurnController : MonoBehaviour {
    public static bool turn; //false for black,true for white
    public static bool ai_switch;
    public Text ui_text;
    private GameObject[] bs;
    private GameObject[] ws;
    private GameObject[] spot;

    // Use this for initialization
    void Awake () {
        TurnController.turn = false;
        ai_switch = false;
	}

    public void AI_ON()
    {
        ai_switch = true;
    }
    public void AI_OFF()
    {
        ai_switch = false;
    }
	
	// Update is called once per frame
	void Update () {
        bs = GameObject.FindGameObjectsWithTag("black");
        ws = GameObject.FindGameObjectsWithTag("white");
        spot = GameObject.FindGameObjectsWithTag("spot");
        
    }

    public void Clear()
    {
        for (int i = 0; i < bs.Length; i++)
            Destroy(bs[i]);
        for (int i = 0; i < ws.Length; i++)
            Destroy(ws[i]);
        for (int i = 0; i < spot.Length; i++)
            Destroy(spot[i]);
        ui_text.text = "";
        TurnController.turn = false;
    }
}
