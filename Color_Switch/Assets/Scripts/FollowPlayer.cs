using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        // If player moves above 0,0 then camera will follow its upward movement
        // It won't follow downward movement
        if(player.position.y > transform.position.y)
        {   
            transform.position = new Vector3(player.position.x, player.position.y, -10f);
        }
    }
}
