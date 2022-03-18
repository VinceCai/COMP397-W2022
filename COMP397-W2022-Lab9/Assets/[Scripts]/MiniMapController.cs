using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapController : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
	    transform.position = new Vector3(player.position.x, 33.0f, player.position.z);

    }
}
