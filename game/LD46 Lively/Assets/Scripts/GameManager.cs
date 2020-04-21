using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
//using Ink.Runtime;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;
    public Node startingNode;

    //public static event Action<Story> OnCreateStory;

    [HideInInspector]
    public Node currentNode;

    public CameraRig rig;

    //vars relating to lighting changes
    //public float normalLight;
    //public float lowLight;
    //public float highLight;

    //public GameObject[] inLights;
    //public Light lt;
    //public float brightness;

    //look up singleton in future to improve this bad one
    private void Awake()
    {
        ins = this;

        // Remove the default message
        //RemoveChildren();
        //StartStory();
    }

    private void Start()
    {
        startingNode.Arrive();
    }

    private void Update()
    {
        //back up from prop

        if (Input.GetMouseButtonDown(1) && currentNode.GetComponent<Prop>() != null)
        {
            currentNode.GetComponent<Prop>().loc.Arrive();
        } //back up from location
        else if (Input.GetMouseButtonDown(1) && currentNode.GetComponent<Location>() != null)
        {
            currentNode.GetComponent<Location>().way.Arrive();
        }
    }



//    // Creates a new Story object with the compiled story which we can then play!
//    void StartStory()
//    {
//        story = new Story(inkJSONAsset.text);
//        if (OnCreateStory != null) OnCreateStory(story);
//        RefreshView();
//    }

//    // This is the main function called every time the story changes. It does a few things:
//    // Destroys all the old content and choices.
//    // Continues over all the lines of text, then displays all the choices. If there are no choices, the story is finished!
//    void RefreshView()
//    {
//        // Remove all the UI on screen
//        RemoveChildren();

//        // Read all the content until we can't continue any more
//        while (story.canContinue)
//        {
//            // Continue gets the next line of the story
//            string text = story.Continue();
//            // This removes any white space from the text.
//            text = text.Trim();
//            // Display the text on screen!
//            CreateContentView(text);
//        }

//        // Get the current tags (if any)
//        List<string> tags = story.currentTags;

//        // If there are tags, search for lighting and location instructions.
//        if (tags.Count > 0)
//        {
//            if (tags.Contains("lit"))
//            {

//                brightness = lt.intensity;

//                inLights = GameObject.FindGameObjectsWithTag("InnerLight");
//                if (tags.Contains("normal"))
//                {
//                    brightness = normalLight;
//                }
//                if (tags.Contains("dark"))
//                {
//                    brightness = lowLight;
//                }
//                if (tags.Contains("bright"))
//                {
//                    brightness = highLight;
//                }
                

//                foreach (GameObject inLight in inLights)
//                {
//                    lt = inLight.GetComponent<Light>();
                    
//                    //DOTween sequence to slow light change
//                    lt.DOIntensity(brightness, .75f);
//                    //lt.intensity = DOTween.brightness;
//                }

//            }
//        }

//            // Display all the choices, if there are any!
//            if (story.currentChoices.Count > 0)
//        {
//            for (int i = 0; i < story.currentChoices.Count; i++)
//            {
//                Choice choice = story.currentChoices[i];
//                Button button = CreateChoiceView(choice.text.Trim());
//                // Tell the button what to do when we press it
//                button.onClick.AddListener(delegate {
//                    OnClickChoiceButton(choice);
//                });
//            }
//        }
//        // If we've read all the content and there's no choices, the story is finished!
//        else
//        {
//            Button choice = CreateChoiceView("End of story.\nRestart?");
//            choice.onClick.AddListener(delegate {
//                StartStory();
//            });
//        }
//    }

//    // When we click the choice button, tell the story to choose that choice!
//    void OnClickChoiceButton(Choice choice)
//    {
//        story.ChooseChoiceIndex(choice.index);
//        RefreshView();
//    }

//    // Creates a textbox showing the line of text
//    void CreateContentView(string text)
//    {
//        Image storyBacker = Instantiate(panelPrefab) as Image;
//        storyBacker.transform.SetParent(canvas.transform, false);
//        Text storyText = Instantiate(textPrefab) as Text;
//        storyText.text = text;
//        storyText.transform.SetParent(storyBacker.transform, false);
//    }

//    // Creates a button showing the choice text
//    Button CreateChoiceView(string text)
//    {
//        // Creates the button from a prefab
//        Button choice = Instantiate(buttonPrefab) as Button;
//        choice.transform.SetParent(canvas.transform, false);

//        // Gets the text from the button prefab
//        Text choiceText = choice.GetComponentInChildren<Text>();
//        choiceText.text = text;

//        // Make the button expand to fit the text
//        HorizontalLayoutGroup layoutGroup = choice.GetComponent<HorizontalLayoutGroup>();
//        //layoutGroup.childForceExpandHeight = false;

//        return choice;
//    }

//    // Destroys all the children of this gameobject (all the UI)
//    void RemoveChildren()
//    {
//        int childCount = canvas.transform.childCount;
//        for (int i = childCount - 1; i >= 0; --i)
//        {
//            GameObject.Destroy(canvas.transform.GetChild(i).gameObject);
//        }
//    }

//    [SerializeField]
//    private TextAsset inkJSONAsset;
//    public Story story;

//    [SerializeField]
//    private Canvas canvas;

//    // UI Prefabs
//    [SerializeField]
//    private Text textPrefab;
//    [SerializeField]
//    private Button buttonPrefab;
//    [SerializeField]
//    private Image panelPrefab;
}
