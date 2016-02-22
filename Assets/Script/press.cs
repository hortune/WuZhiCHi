using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class press : MonoBehaviour
{
    public GameObject white;
    public GameObject black;
    private GameObject plat;
    private GameObject text;
    private Text re;
    private GameObject g;
    private AI ai;
    public static bool[,] used_pos = new bool[19, 19];
    public static int[,] pos_id = new int[19, 19];//1為白 2為黑
    public void Awake()
    {
        for (int i = 0; i < 19; i++)
            for (int j = 0; j < 19; j++)
            {
                used_pos[i, j] = false;
                pos_id[i, j] = 0;
            }
    }
    void OnMouseDown()
    {
        int x = (int)((gameObject.transform.position.x + 55f) / 6f);
        int y = (int)((gameObject.transform.position.z + 51.5f) / 6f);
        if (!used_pos[x, y])
        {
            if (TurnController.turn == false)
            {
                g = Instantiate(black, gameObject.transform.position, Quaternion.identity) as GameObject;
                pos_id[x, y] = 2;
            }
            else
            {
                g = Instantiate(white, gameObject.transform.position, Quaternion.identity) as GameObject;
                pos_id[x, y] = 1;
            }

            TurnController.turn = !TurnController.turn;
            Destroy(gameObject);

            used_pos[x, y] = true;

            text = GameObject.FindGameObjectWithTag("result");
            re = text.GetComponent<Text>();
            plat = GameObject.FindGameObjectWithTag("Player");
            ai = plat.GetComponent<AI>();

            for (int i = 2; i < 17; i++)
                for (int j = 2; j < 17; j++)
                {
                    if (press.pos_id[i, j] == 1 && press.pos_id[i - 1, j] == 1 && press.pos_id[i - 2, j] == 1 && press.pos_id[i + 1, j] == 1 && press.pos_id[i + 2, j] == 1)
                    {
                        re.text = "White Wins!!! Press Clear To Replay";
                    }
                    else if (press.pos_id[i, j] == 2 && press.pos_id[i - 1, j] == 2 && press.pos_id[i - 2, j] == 2 && press.pos_id[i + 1, j] == 2 && press.pos_id[i + 2, j] == 2)
                    {
                        re.text = "Black Wins!!! Press Clear To Replay";
                    }
                    else if (press.pos_id[i, j] == 1 && press.pos_id[i, j - 1] == 1 && press.pos_id[i, j - 2] == 1 && press.pos_id[i, j + 1] == 1 && press.pos_id[i, j + 2] == 1)
                    {
                        re.text = "White Wins!!! Press Clear To Replay";
                    }
                    else if (press.pos_id[i, j] == 2 && press.pos_id[i, j - 1] == 2 && press.pos_id[i, j - 2] == 2 && press.pos_id[i, j + 1] == 2 && press.pos_id[i, j + 2] == 2)
                    {
                        re.text = "Black Wins!!! Press Clear To Replay";
                    }
                    else if (press.pos_id[i, j] == 1 && press.pos_id[i - 1, j - 1] == 1 && press.pos_id[i - 2, j - 2] == 1 && press.pos_id[i + 1, j + 1] == 1 && press.pos_id[i + 2, j + 2] == 1)
                    {
                        re.text = "White Wins!!! Press Clear To Replay";
                    }
                    else if (press.pos_id[i, j] == 2 && press.pos_id[i - 1, j - 1] == 2 && press.pos_id[i - 2, j - 2] == 2 && press.pos_id[i + 1, j + 1] == 2 && press.pos_id[i + 2, j + 2] == 2)
                    {
                        re.text = "Black Wins!!! Press Clear To Replay";
                    }
                }

            ai.AI_turn();
        }
    }
}