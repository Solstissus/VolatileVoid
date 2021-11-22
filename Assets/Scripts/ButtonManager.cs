using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Takes player to intro dialogue
    public void Dialogue01 ()
    {
        SceneManager.LoadScene("Dialogue01");
    }
    // Takes player to first question scene
    public void QuestionScene ()
    {
        SceneManager.LoadScene("QuestionScene");
    }

    // Takes player to angry Tobio end scene
    public void NoScene ()
    {
        SceneManager.LoadScene("NoScene");
    }

    // Takes player to cursor selection 
    public void PetScene ()
    {
        SceneManager.LoadScene("PetScene");
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
