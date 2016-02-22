using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
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

    bool Detect_four()
    {
        for (int i = 0; i < 19; i++)
            for (int j = 0; j < 19; j++)
            {
                if (press.used_pos[i, j] == false)
                {
                    if (i >= 4 && press.pos_id[i - 4, j] == 1 && press.pos_id[i - 1, j] == 1 && press.pos_id[i - 2, j] == 1 && press.pos_id[i - 3, j] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (j >= 4 && press.pos_id[i, j - 4] == 1 && press.pos_id[i, j - 1] == 1 && press.pos_id[i, j - 2] == 1 && press.pos_id[i, j - 3] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (i >= 4 && j >= 4 && press.pos_id[i - 4, j - 4] == 1 && press.pos_id[i - 1, j - 1] == 1 && press.pos_id[i - 2, j - 2] == 1 && press.pos_id[i - 3, j - 3] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (i >= 4 && j <= 14 && press.pos_id[i - 4, j + 4] == 1 && press.pos_id[i - 1, j + 1] == 1 && press.pos_id[i - 2, j + 2] == 1 && press.pos_id[i - 3, j + 3] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                }
            }
        return false;
    }

    bool Detect_three()
    {
        for (int i = 0; i < 19; i++)
            for (int j = 0; j < 19; j++)
            {
                if (press.used_pos[i, j] == false)
                {
                    if (i >= 3 && press.pos_id[i - 3, j] == 1 && press.pos_id[i - 1, j] == 1 && press.pos_id[i - 2, j] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (j >= 3 && press.pos_id[i, j - 3] == 1 && press.pos_id[i, j - 1] == 1 && press.pos_id[i, j - 2] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (i >= 3 && j >= 3 && press.pos_id[i - 3, j - 3] == 1 && press.pos_id[i - 1, j - 1] == 1 && press.pos_id[i - 2, j - 2] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (i >= 3 && j <= 13 && press.pos_id[i - 3, j + 3] == 1 && press.pos_id[i - 1, j + 1] == 1 && press.pos_id[i - 2, j + 2] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                }
            }
        return false;
    }

    bool Detect_two()
    {
        for (int i = 0; i < 19; i++)
            for (int j = 0; j < 19; j++)
            {
                if (press.used_pos[i, j] == false)
                {
                    if (i >= 2 && press.pos_id[i - 2, j] == 1 && press.pos_id[i - 1, j] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (j >= 2 && press.pos_id[i, j - 2] == 1 && press.pos_id[i, j - 1] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (i >= 2 && j >= 2 && press.pos_id[i - 2, j - 2] == 1 && press.pos_id[i - 1, j - 1] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                    else if (i >= 2 && j <= 12 && press.pos_id[i - 2, j + 2] == 1 && press.pos_id[i - 1, j + 1] == 1)
                    {
                        Play(i, j);
                        return true;
                    }
                }
            }
        return false;
    }

    void Default()
    {
        float x = Random.Range(5f, 12f);
        float y = Random.Range(5f, 12f);

        if (press.used_pos[(int)x, (int)y] == false)
            Play((int)x, (int)y);
        else
            Default();
    }

    public void AI_turn () {
        if (Detect_mid())
            Play(9, 9);
        else if (Detect_four()) ;
        else if (Detect_three()) ;
        else if (Detect_two()) ;
        else
            Default();
	}
}
