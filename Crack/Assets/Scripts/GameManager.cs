
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    bool possibility = true;
    int left = 0, right = 0, common = 0;

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

    private void Check()
    {

        if (possibility)
        {
            if (left > 0 && right > 0)
            {
                possibility = false;
            }
            else if (left == 4 && common == 4 && right == 0)
            {
                Completed();
            }
            else if (left == 0 && common == 4 && right == 4)
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
