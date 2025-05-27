using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coinbutton : MonoBehaviour
{
    public int Score = 0;
    public TextMeshProUGUI textname;
    public Animator animator;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textname.text = "Score :" + Score.ToString();
        
    }
    public void ScoreUp()
    {
        Debug.Log("스코어 업");
        Score++;

        animator.SetTrigger("Act");
    }


   

}
