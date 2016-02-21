using UnityEngine;
using System.Collections;

public class press : MonoBehaviour
{
    public GameObject white;
    public GameObject black;
    private GameObject g;
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
        }
    }
}