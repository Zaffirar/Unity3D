using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;
    public float restartDelay = 2f;
    public void EndGame(){
        if(gamehasEnded == false){
            gamehasEnded=true;
            Debug.Log("End");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
