using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{ 

    // Rooms
    [SerializeField] private int _roomIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == Structs.Tags.playerTag)
        {
            Debug.Log("Collision");
            SceneManager.LoadScene(_roomIndex);
        }
    }
}
