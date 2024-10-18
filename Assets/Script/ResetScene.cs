using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
   
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void Resetscene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
