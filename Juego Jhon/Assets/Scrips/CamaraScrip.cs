using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScrip : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        {
            Vector3 position = transform.position;
            position.x = player.transform.position.x;
            transform.position = position;
        }
    }
}
