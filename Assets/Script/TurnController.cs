using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurnController : MonoBehaviour {
    public bool turn; //false for black,true for white
    public Text ui_text;
    private GameObject[] bs;
    private GameObject[] ws;

    // Use this for initialization
    void Start () {
        turn = false;
        Debug.Log("false");
	}
	
	// Update is called once per frame
	void Update () {
        bs = GameObject.FindGameObjectsWithTag("black");
        ws = GameObject.FindGameObjectsWithTag("white");
        for (int i = 2; i < 17; i++)
            for (int j = 2; j < 17; j++)
            {
                if (press.pos_id[i, j] == 1 && press.pos_id[i - 1, j] == 1 && press.pos_id[i - 2, j] == 1 && press.pos_id[i + 1, j] == 1 && press.pos_id[i + 2, j] == 1)
                {
                    ui_text.text = "White Wins!!! Press Clear To Replay";
                }
                else if (press.pos_id[i, j] == 2 && press.pos_id[i - 1, j] == 2 && press.pos_id[i - 2, j] == 2 && press.pos_id[i + 1, j] == 2 && press.pos_id[i + 2, j] == 2)
                {
                    ui_text.text = "Black Wins!!! Press Clear To Replay";
                }
                else if (press.pos_id[i, j] == 1 && press.pos_id[i, j - 1] == 1 && press.pos_id[i, j - 2] == 1 && press.pos_id[i, j + 1] == 1 && press.pos_id[i, j + 2] == 1)
                {
                    ui_text.text = "White Wins!!! Press Clear To Replay";
                }
                else if (press.pos_id[i, j] == 2 && press.pos_id[i, j - 1] == 2 && press.pos_id[i, j - 2] == 2 && press.pos_id[i, j + 1] == 2 && press.pos_id[i, j + 2] == 2)
                {
                    ui_text.text = "Black Wins!!! Press Clear To Replay";
                }
                else if (press.pos_id[i, j] == 1 && press.pos_id[i - 1, j - 1] == 1 && press.pos_id[i - 2, j - 2] == 1 && press.pos_id[i + 1, j + 1] == 1 && press.pos_id[i + 2, j + 2] == 1)
                {
                    ui_text.text = "White Wins!!! Press Clear To Replay";
                }
                else if (press.pos_id[i, j] == 2 && press.pos_id[i - 1, j - 1] == 2 && press.pos_id[i - 2, j - 2] == 2 && press.pos_id[i + 1, j + 1] == 2 && press.pos_id[i + 2, j + 2] == 2)
                {
                    ui_text.text = "Black Wins!!! Press Clear To Replay";
                }
            }
    }

    public void Clear()
    {
        for (int i = 0; i < bs.Length; i++)
            Destroy(bs[i]);
        for (int i = 0; i < ws.Length; i++)
            Destroy(ws[i]);
        ui_text.text = "";
        turn = false;
        Debug.Log("false");
    
    ui_text.text = "fk u";
    }
}
