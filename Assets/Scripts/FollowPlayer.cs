// directions for the Camera

using UnityEngine;


public class FollowPlayer : MonoBehaviour
{ 


    public Transform player;
    public Vector3 offset;        // camera offset variable, set numbers in inspector

    
    void Update()     // Update is called once per frame
    {
        transform.position = player.position + offset;
    }
}
