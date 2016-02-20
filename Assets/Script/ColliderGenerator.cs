using UnityEngine;
using System.Collections;

public class ColliderGenerator : MonoBehaviour {
    public GameObject spot;
    public GameObject[][] emptyspot;
    private GameObject tem;
    private Vector3 gen_pos;
	// Use this for initialization
	void Start () {
        gen_pos = new Vector3(-55f, 0.5f, -51.5f);
        
        for(int i=0;i<19;i++)
        {
            for(int j=0;j<19;j++)
            {
                tem = Instantiate(spot, gen_pos, Quaternion.identity) as GameObject;
                gen_pos.z += 6f;
            }
            gen_pos.z = -51.5f;
            gen_pos.x += 6f;
        }
	}
}
