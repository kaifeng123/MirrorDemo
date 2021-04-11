using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class CubeMove : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;
        if(Input.GetMouseButton(0))
        {
         Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;
            transform.position = mousePosition;
        }
    }
}
