using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelGenerator : MonoBehaviour
{
   private string jsonString;

   [SerializeField] private TextAsset jsonFile;

   public TextMeshProUGUI displayQuestion;
    public TextMeshProUGUI displayAnswer1;
    public TextMeshProUGUI displayAnswer2;
    public TextMeshProUGUI displayAnswer3;
    


    //Data Class
   private class Data
   {
      public int id;
      public string question;
      public string[] answer = new string[4];
      public int correct;
   }

    private void Awake()
    {
    }

    private void Start(){

        jsonString = jsonFile.text;
        Data data = JsonUtility.FromJson<Data>(jsonString);
        string questionString = data.question;
        string[] answerString = data.answer;
        int correct = data.correct;

        

        displayQuestion.text = "Question: " + questionString;
        displayAnswer1.text = "Answer1: " + answerString[0];
        displayAnswer2.text = "Answer2: " + answerString[1];
        displayAnswer3.text = "Answer3: " + answerString[2];

        // if the text successfully displayed, then debug log
        if (displayQuestion.text != null)
        {
            Debug.Log("Question: " + questionString);
            Debug.Log("Answer1: " + answerString[0]);
            Debug.Log("Answer2: " + answerString[1]);
            Debug.Log("Answer3: " + answerString[2]);
            Debug.Log("Success");
        }

    }
}
