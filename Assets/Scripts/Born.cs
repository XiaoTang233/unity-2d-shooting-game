using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Born : MonoBehaviour {

    public GameObject playerPrefab;

    public GameObject[] enemyPrefabList;

    //判断是否产生敌人
    public bool createPlay;

	// Use this for initialization
	void Start () {
        Invoke("BornTank",0.5f);
        Destroy(gameObject,1f);
	}

    private void Update()
    {

    }

    private void BornTank()
    {
        if (createPlay)
        {
            GameObject player= Instantiate(playerPrefab, transform.position, Quaternion.identity);
            GlobalData.tank_clone_list.Add(player);
        }
        else
        {
            int num = Random.Range(0, 4);
            GameObject enemy = Instantiate(enemyPrefabList[num], transform.position, Quaternion.identity);
            GlobalData.tank_clone_list.Add(enemy);
        }
    }
    public void DestroyAllTank()
    {
        for (int i=0;i< GlobalData.tank_clone_list.Count; i++)
        {
            Destroy(GlobalData.tank_clone_list[i]);
        }
    }
}
