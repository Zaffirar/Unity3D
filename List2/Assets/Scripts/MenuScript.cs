using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void triggerMenuBehavior(int i){
        if(i==0){
            Debug.Log(0);
            SceneManager.LoadScene("Level");
        }else if(i==1){
            Application.Quit();
        }
    }
}
