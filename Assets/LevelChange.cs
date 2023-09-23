using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Test");
        if (other.gameObject.CompareTag("Player")) {  

            // Загрузите новую сцену
            SceneManager.LoadScene("Puzzles3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
