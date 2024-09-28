using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Field for setting player
    [SerializeField] private Transform player;

    private void Update()
    {
        //Follow the player's x,y,z position
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
