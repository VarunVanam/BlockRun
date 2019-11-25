
using UnityEngine;
using UnityEngine.SceneManagement;
public class restartgame : MonoBehaviour {
    bool gameHasEnded = false;
    public GameObject completelevelUI;
 public void completelevel ()
    {
        completelevelUI.SetActive(true);
    }
    public void Endgame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            Debug.Log("game over");
            Restart();
        }
    }
	void Restart () {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
