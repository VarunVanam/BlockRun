
using UnityEngine;

public class collision : MonoBehaviour
{
    public player2 movement;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obstacle")
        {
            Debug.Log("we got hit!!!!!!!!!!!!!");
            movement.enabled = false;
            FindObjectOfType<restartgame>().Endgame();
        }
    }
}