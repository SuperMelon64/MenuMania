using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidgetScript : MonoBehaviour
{
    public void Forget()
    {
        Destroy(this.gameObject);
    }
}
