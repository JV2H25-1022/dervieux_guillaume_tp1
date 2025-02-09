using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rouge : MonoBehaviour
{
    public GameObject objetADesactiver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
//         if (gameObject.CompareTag("Cible"))
// {
//     Destroy(gameObject);
// }
    }

void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Cible"))
        {
            
            Destroy(collision.gameObject);
        } else if(collision.gameObject.CompareTag("terminus")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
