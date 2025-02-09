using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactiverObjet : MonoBehaviour
{
    public GameObject objetADesactiver;
    // Start is called before the first frame update
    public void Desactiver()
    {
        objetADesactiver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
