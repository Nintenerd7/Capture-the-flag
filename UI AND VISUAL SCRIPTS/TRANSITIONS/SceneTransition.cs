using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(Transition());
    }
  public IEnumerator Transition()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);

    }
}
