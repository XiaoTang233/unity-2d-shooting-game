using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    //属性值
    public int playerScore = 0;
    public bool isDead=false;
    public bool isDefeat;

    //引用
    public GameObject born;
    private static PlayerManager instance;
    public static PlayerManager Instance
    {
        get
        {
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    public void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isDead)
        {
            Recover();
        }
	}

    private void Recover()
    {
        if (GlobalData.lifeVale == 1)
        {
            //游戏失败
            SceneManager.LoadScene("EndGame");
            //SceneManager.LoadScene("Game");
        }
        else
        {
            GlobalData.lifeVale--;
            //更新生命值
            GlobalData.life_text.GetComponent<TextMesh>().text = "生命：" + GlobalData.lifeVale.ToString();
            GameObject go = Instantiate(born,new Vector3(-7,-8,0),Quaternion.identity);
            go.GetComponent<Born>().createPlay = true;
            isDead = false;
        }
    }
}
