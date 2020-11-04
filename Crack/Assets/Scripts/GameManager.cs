
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    bool possibility = true;
    int left = 0, right = 0, common = 0, commonup = 0;

    public void HitOthers()
    {
        possibility = false;
    }

    public void HitLeft() {
        left++;
        Check();
    }

    public void HitRight()
    {
        right++;
        Check();
    }

    public void HitCommon()
    {
        common++;
        Check();
    }

    public void HitCommonUp()
    {
        commonup++;
        Check();
    }

    private void Check()
    {

        if (possibility)
        {
            if (left > 0 && right > 0)
            {
                possibility = false;
            }
            else if (left == 4 && common == 2 && commonup == 2 && right == 0)
            {
                Completed();
            }
            else if (left == 0 && common == 2 && commonup == 2 && right == 4)
            {
                Completed();
            }
            else if (left == 0 && common == 2 && commonup == 2 && right == 0)
            {
                Completed();
            }
            else if (left == 4 && common == 2 && commonup == 0 && right == 0)
            {
                Completed();
            }

        }
    }

    private void Completed() {
       // Debug.Log("Completed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
