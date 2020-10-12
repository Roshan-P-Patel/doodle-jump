using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
    public Object scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnBecameInvisible()
    {
        SceneManager.LoadScene(scene.name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
