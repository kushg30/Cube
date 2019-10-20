
using UnityEngine;

public class playcollision : MonoBehaviour
{
    public movement move;
    

      void OnCollisionEnter(Collision collisionInfo)

    {   
        if(collisionInfo.collider.tag=="Obstacle")
        {
            move.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }


        
    }





}
