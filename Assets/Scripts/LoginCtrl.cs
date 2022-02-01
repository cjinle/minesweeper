using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginCtrl : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("login ctrl load.");
    }

    public void GotoMain()
    {
        SceneManager.LoadScene("Main");
    }

    
}
