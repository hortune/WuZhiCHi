using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
    private int[,] con_four = new int[4, 4];
    private int[,] alive_three = new int[3, 4];
    private int[,,] duo_alive_three = new int[3, 4, 2];
    private int[,,] duo_alive_two = new int[1, 4, 2];
    public GameObject b_chess;

    void Play(int i, int j)
    {
        GameObject tem;
        Vector3 pos = new Vector3(i * 6f - 55f, 0.5f, j * 6f - 51.5f);
        tem = Instantiate(b_chess, pos, Quaternion.identity) as GameObject;

        press.pos_id[i, j] = 2;
        press.used_pos[i, j] = true;
        TurnController.turn = !TurnController.turn;
    }

    bool Detect_mid()
    {
        if (press.used_pos[9, 9] == false)
            return true;
        return false;
    }

    bool Detect_four(int i,int j)
    {
        if (press.pos_id[i, j] == 1 && press.pos_id[i - 1, j] == 1 && press.pos_id[i - 2, j] == 1 && press.pos_id[i - 3, j] == 1)
            return true;
        else if (press.pos_id[i, j] == 1 && press.pos_id[i, j - 1] == 1 && press.pos_id[i, j - 2] == 1 && press.pos_id[i, j - 3] == 1)
            return true;
        else if (press.pos_id[i, j] == 1 && press.pos_id[i - 1, j - 1] == 1 && press.pos_id[i - 2, j - 2] == 1 && press.pos_id[i - 3, j - 3] == 1)
            return true;
        else if (press.pos_id[i, j] == 1 && press.pos_id[i - 1, j + 1] == 1 && press.pos_id[i - 2, j + 2] == 1 && press.pos_id[i - 3, j + 3] == 1)
            return true;
        else
            return false;
    }

	// Update is called once per frame
	void Update () {
	    for(int i=0;i<19;i++)
            for(int j=0;j<19;j++)
            {
                if (Detect_mid() == true)
                    Play(9, 9);
                else if (Detect_four(i, j) == true)
                    Play(i, j);
            }
	}
}
