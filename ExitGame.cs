using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Hey, come back here, you beeg monkey!");
    }
}
