using UnityEngine;
using UnityEngine.UI;

public class PasswordScript : MonoBehaviour
{
    private InputField inPass;
    public GameObject spawnpt;

    private void Start()
    {
        inPass = GetComponent<InputField>();
    }

    public void CheckPass()
    {
        switch (inPass.text)
        {
            case "password":
                Instantiate(Resources.Load("Widgets/Widget1") as GameObject, spawnpt.transform);
                break;

            case "worldtwo":
                Instantiate(Resources.Load("Widgets/Widget2") as GameObject, spawnpt.transform);
                break;

            case "threeheehee":
                Instantiate(Resources.Load("Widgets/Widget3") as GameObject, spawnpt.transform);
                break;

            case "credits":
                Instantiate(Resources.Load("Widgets/Widget4") as GameObject, spawnpt.transform);
                break;

            case "wizlord":
                Instantiate(Resources.Load("Widgets/Widget5") as GameObject, spawnpt.transform);
                break;

            case "clever":
                Instantiate(Resources.Load("Widgets/Widget6") as GameObject, spawnpt.transform);
                break;

            default:
                inPass.text = "";
                break;
        }
    }
}
