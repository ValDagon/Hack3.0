using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ProgressBar;
public class Button : MonoBehaviour
{
    public void StartHack()
    {
        var progressBar = new ProgressBar();
        progressBar.IncrementProgress(1f);
    }
}
