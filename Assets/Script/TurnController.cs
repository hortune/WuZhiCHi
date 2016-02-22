using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurnController : MonoBehaviour {
    public static bool turn; //false for black,true for white
    public Text ui_text;
    public AI ai;
    public ColliderGenerator cg;
    private GameObject[] bs;
    private GameObject[] ws;
    private GameObject[] spot;

    // Use this for initialization
    void Awake () {
        TurnController.turn = false;
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
        ai.enabled = false;
        cg.enabled = false;
        TurnController.turn = false;
    }
}
