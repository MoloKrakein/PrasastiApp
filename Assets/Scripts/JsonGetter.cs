using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
// import textmeshpro
using TMPro;

public class JsonGetter : MonoBehaviour
{


    private string jsonString;
    // get json file location and read it
    // public string jsonString;

    // file path by using by drag and drop to editor
    [SerializeField] private TextAsset jsonFile;

    //get text to display tmp
    public TextMeshProUGUI textDisplay;

    private void Awake() {
        // FindObjectOfType<text>
    }
    void Start()
    {
        //find GameObject with name TextDisplay and change text


        jsonString = jsonFile.text;
        Data data = JsonUtility.FromJson<Data>(jsonString);
            string questionString = data.question;
            string[] answerString = data.answer;
            int correct = data.correct;

        // read json file and display on debug






    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public class Data
    {
        public int id;
        public string question;
        
        // fill array of answer with for loop
        public string[] answer = new string[4];

        public int correct;

    }

    
    //class button is pressed and show hello world in debug
    public void ButtonPressed()
    {
        jsonString = jsonFile.text;
        Data data = JsonUtility.FromJson<Data>(jsonString);
        string questionString = data.question;

        // array of answer
        // string[] answerString = data.answer;

        // Debug.Log("Hello World");
        Debug.Log(data.question);
        Debug.Log(data.answer[0]);
        Debug.Log(data.answer[1]);
        Debug.Log(data.answer[2]);
        Debug.Log(data.answer[3]);
        // Debug.Log("Correct :");
        // Debug.Log(data.correct);

        // locate correct answer
        int correctAnswer = data.correct;
        Debug.Log("Correct answer is :");
        Debug.Log(data.answer[correctAnswer]);

        // change text to display
        textDisplay.text = questionString;
        

    }
}
