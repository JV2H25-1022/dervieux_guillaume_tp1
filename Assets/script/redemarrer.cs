using UnityEngine;
using UnityEngine.SceneManagement;

public class Redemarrer : MonoBehaviour
{
    // Fonction publique pour recharger la scène
    public void Recommencer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
