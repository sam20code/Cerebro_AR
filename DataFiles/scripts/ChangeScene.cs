using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextscene1()
    {
        SceneManager.LoadScene("Info");
    }
   public void Video()
    {
        SceneManager.LoadScene("Video");
    }
    public void final()
    {
        SceneManager.LoadScene("CerebroThankYou");
    }
    public void back()
    {
        SceneManager.LoadScene("Info");
    }

}
