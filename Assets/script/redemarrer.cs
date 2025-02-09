using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class redemarrer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Redemarrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        string nomSceneActuel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nomSceneActuel);
    }
}
