using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public static int dirCount = 0;
    public static int curLevel = 1;
    public static GameObject level_text;
    public static GameObject score_text;
    public static GameObject life_text;
    public static GameObject levelup;
    public static List<GameObject> tank_clone_list = new List<GameObject>();
    public static int lifeVale = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
