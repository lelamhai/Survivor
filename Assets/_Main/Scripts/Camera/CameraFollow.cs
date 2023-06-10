using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class CameraFollow : Singleton<CameraFollow>
{
    public void FollowPlayer(Transform player)
    {
        Debug.Log("FollowPlayer");
        this.transform.position = new Vector3(player.position.x, player.position.y, this.transform.position.z);
    }
}
