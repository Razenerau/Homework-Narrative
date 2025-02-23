using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // Tags
    private const string _PLAYERTAG = "Player";

    // Rooms
    [SerializeField] private int _roomIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == _PLAYERTAG)
        {
            Debug.Log("Collision");
            SceneManager.LoadScene(_roomIndex);
        }
    }
}
