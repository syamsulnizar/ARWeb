using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class close : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas start;
    public Button exit;

    public void keluar()
    {
        Application.Quit();
    }
}
