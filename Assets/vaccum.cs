using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class vaccum : MonoBehaviour
{
    //public GameObject tilemapObj;

    Tilemap tilemap;

    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        //tilemap = tilemapObj.GetComponent<Tilemap>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dirt")
        {
            rend = collision.gameObject.GetComponent<SpriteRenderer>();
            rend.enabled = false;
        }
        
    }
}
