using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickRandom : MonoBehaviour
{
    float randomNumber = Random.Range(1, 3);
   




// Start is called before the first frame update
void Start()
    {
        StartCoroutine(WaitForSceneLoad());
    }

    IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(2);
    }

    
    
     
    
        
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
