using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginCtrl : MonoBehaviour
{
    public void GotoMain()
    {
        SceneManager.LoadScene("Main");
    }
    
}
