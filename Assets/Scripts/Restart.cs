using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void RestartGame ()
    {
        SceneManager.LoadScene(4);
    }

    public void EndGame ()
    {
        SceneManager.LoadScene(3);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
