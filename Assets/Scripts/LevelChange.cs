using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public Font myFont;
    public FontStyle blod;
    public GameObject born;
    // Start is called before the first frame update
    void Start()
    {
        //GlobalData.level_text.GetComponent<TextMesh>().text = "关卡：" + GlobalData.curLevel.ToString() ;
    }


    public void increaselevel()
    {
        if (GlobalData.curLevel < 3)
        {
            //显示level up
            GlobalData.levelup = new GameObject();
            GlobalData.levelup.transform.position = new Vector3(-8, 2, 0);
            GlobalData.levelup.AddComponent<TextMesh>();
            GlobalData.levelup.GetComponent<TextMesh>().text = "LEVEL UP!!";
            GlobalData.levelup.GetComponent<TextMesh>().font = myFont;
            GlobalData.levelup.GetComponent<MeshRenderer>().sortingOrder = 3;
            GlobalData.levelup.GetComponent<TextMesh>().fontSize = 30;
            GlobalData.levelup.GetComponent<TextMesh>().fontStyle = blod;

            Invoke("destroyText", 0.8f);
            GlobalData.curLevel = GlobalData.curLevel+1;
            GlobalData.level_text.GetComponent<TextMesh>().text = "关卡：" + GlobalData.curLevel.ToString();
        }
        else if(GlobalData.curLevel == 3)//通过三关，胜利
        {
            SceneManager.LoadScene("WinGame");
        }
        
    }

    public void destroyText()
    {
        Destroy(GlobalData.levelup);
        born.GetComponent<Born>().DestroyAllTank();
        if(GlobalData.curLevel == 2)
        {
            //生成玩家
            GameObject go = Instantiate(born, new Vector3(-7, -8, 0), Quaternion.identity);
            go.GetComponent<Born>().createPlay = true;
            GlobalData.tank_clone_list.Add(go);
            //生成敌人
            CreateItem(born, new Vector3(-4, 5, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-2, 0, 0), Quaternion.identity);
            CreateItem(born, new Vector3(3, 7, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-2, 3, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-3, -4, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-6, 8, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-5, 5, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-1, 0, 0), Quaternion.identity);
            CreateItem(born, new Vector3(4, 0, 0), Quaternion.identity);
        }
        else if(GlobalData.curLevel == 3)
        {
            //生成玩家
            GameObject go = Instantiate(born, new Vector3(-7, -8, 0), Quaternion.identity);
            go.GetComponent<Born>().createPlay = true;
            GlobalData.tank_clone_list.Add(go);
            //生成敌人
            CreateItem(born, new Vector3(-4, 5, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-2, 0, 0), Quaternion.identity);
            CreateItem(born, new Vector3(4, 8, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-4, 6, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-2, 1, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-4, -6, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-5, -5, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-1, 0, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-4, 5, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-6, 3, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-3, 5, 0), Quaternion.identity);
            CreateItem(born, new Vector3(4, -4, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-8, -4, 0), Quaternion.identity);
            CreateItem(born, new Vector3(-3, 6, 0), Quaternion.identity);
            CreateItem(born, new Vector3(7, 7, 0), Quaternion.identity);
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
    private void CreateItem(GameObject createGameObject, Vector3 createPosition, Quaternion createRotate)
    {
        GameObject itemGo = Instantiate(createGameObject, createPosition, createRotate);
        GlobalData.tank_clone_list.Add(itemGo);
    }
}
