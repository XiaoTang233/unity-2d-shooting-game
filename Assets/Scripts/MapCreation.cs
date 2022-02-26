using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreation : MonoBehaviour {

    //用来装饰初始化地图所需物体的数组
    public GameObject[] item;
    public Font myFont;
    public FontStyle blod;
    public GameObject map;
    

    private void Awake()
    {
        //绘制地图
        Instantiate(map);
        //初始化玩家
        GameObject go = Instantiate(item[0], new Vector3(-7, -8, 0), Quaternion.identity);
        go.GetComponent<Born>().createPlay = true;

        //初始化关卡文字
        GlobalData.level_text = new GameObject();
        GlobalData.level_text.transform.position = new Vector3(-17, 8, 0);
        GlobalData.level_text.AddComponent<TextMesh>();
        GlobalData.level_text.GetComponent<TextMesh>().text = "关卡："+GlobalData.curLevel.ToString();
        GlobalData.level_text.GetComponent<TextMesh>().font = myFont;
        GlobalData.level_text.GetComponent<TextMesh>().fontStyle = blod;

        //初始化得分文字
        GlobalData.score_text = new GameObject();
        GlobalData.score_text.transform.position = new Vector3(-17, 6, 0);
        GlobalData.score_text.AddComponent<TextMesh>();
        GlobalData.score_text.GetComponent<TextMesh>().text = "得分："+ PlayerManager.Instance.playerScore;
        GlobalData.score_text.GetComponent<TextMesh>().font = myFont;
        GlobalData.score_text.GetComponent<TextMesh>().fontStyle = blod;

        //初始化生命文字
        GlobalData.life_text = new GameObject();
        GlobalData.life_text.transform.position = new Vector3(-17, 4, 0);
        GlobalData.life_text.AddComponent<TextMesh>();
        GlobalData.life_text.GetComponent<TextMesh>().text = "生命："+GlobalData.lifeVale.ToString();
        GlobalData.life_text.GetComponent<TextMesh>().font = myFont;
        GlobalData.life_text.GetComponent<TextMesh>().fontStyle = blod;



        //产生敌人
        CreateItem(item[0], new Vector3(-4,5,0),Quaternion.identity);
        CreateItem(item[0], new Vector3(-2, 0, 0), Quaternion.identity);
        CreateItem(item[0], new Vector3(4, 8, 0), Quaternion.identity);

        //第一次调用CreateEnemy用4s，每隔5s开调用
        InvokeRepeating("CreateEnemy",3,5);

    }

 

    private void CreateItem(GameObject createGameObject,Vector3 createPosition,Quaternion createRotate)
    {
        GameObject itemGo = Instantiate(createGameObject, createPosition, createRotate);
        itemGo.transform.SetParent(gameObject.transform);
        //itemPositionList.Add(createPosition);
    }


    //产生敌人的方法
    private void CreateEnemy()
    {
        int num = Random.Range(0, 3);
        Vector3 EnemyPos = new Vector3();
        if(num==0)
        {
            EnemyPos = new Vector3(-4, 5, 0);
        }else if(num==1)
        {
            EnemyPos = new Vector3(-4, 0, 0);
        }
        else
        {
            EnemyPos = new Vector3(4, 8, 0);
        }

        CreateItem(item[0],EnemyPos,Quaternion.identity);
    }

}
