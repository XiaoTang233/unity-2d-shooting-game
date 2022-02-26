using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoGame : MonoBehaviour
{
    public void OnIntoButtonClick()
    {
        SceneManager.LoadScene("Game");
        GlobalData.curLevel = 1;
        GlobalData.lifeVale = 5;
}
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1080, 600, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
