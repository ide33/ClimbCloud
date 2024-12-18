using UnityEngine;
using UnityEngine.SceneManagement;  // LoadSceneを使うために必要

public class ClearDirector : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
