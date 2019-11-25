
using UnityEngine;

public class triggerlevel : MonoBehaviour
{
    public restartgame leveltrigger;
    void OnTriggerEnter()
    {
        leveltrigger.completelevel();
    }
}