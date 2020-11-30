using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovment movment;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle"){
            movment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
