using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    public GameObject Question_1;
    public GameObject Answers;
    public Button Home_Question;
    public Button Button_Back;

    public void Click_Button_QS1()
    {
        Question_1.SetActive(false);
        Answers.SetActive(true);
        Home_Question.gameObject.SetActive(true);
        Button_Back.gameObject.SetActive(false);
       // Answers.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
    }

    public void Home_QS()
    {
        Question_1.SetActive(true);
        Answers.SetActive(false);
        Home_Question.gameObject.SetActive(false);
        Button_Back.gameObject.SetActive(true);
    }

    public void BT_Back()
    {
        SceneManager.LoadScene(0);
    }
}
