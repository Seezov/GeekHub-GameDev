using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PaintTracker : MonoBehaviour {


    GameObject GetClosestObject()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Painting");
        GameObject showMoreButton = GameObject.Find("ShowMoreButton");
        GameObject closestObject = objectsWithTag[0];
        foreach (GameObject obj in objectsWithTag)
        {
            //compares distances
            if (Vector3.Distance(transform.position, obj.transform.position) <=
                Vector3.Distance(transform.position, closestObject.transform.position))
            {
                closestObject = obj;
            }

        }
        if (Vector3.Distance(transform.position, closestObject.transform.position) <= 3.5f)
        {
            showMoreButton.GetComponent<Image>().enabled = true;
            showMoreButton.GetComponentInChildren<Text>().enabled = true;
        }
        else
        {
            showMoreButton.GetComponent<Image>().enabled = false;
            showMoreButton.GetComponentInChildren<Text>().enabled = false;
        }
        return closestObject;
        
    }
    // Use this for initialization
	void Start () {
        
    }
    // Update is called once per frame
    void Update ()
	{
        GameObject NPTextObj = GameObject.Find("NearestPaintingText");
        Text NPText = NPTextObj.GetComponent<Text>();
        NPText.text = GetClosestObject().name;
        GameObject InfoPanel = GameObject.Find("PaintingInfo");
        Text InfoText = InfoPanel.GetComponent<Text>();
        switch (GetClosestObject().name)
        {
            case "Mona Lisa":
                InfoText.text = "The Mona Lisa or La Gioconda, is a half-length portrait of a woman by the Italian Renaissance artist " +
                            "Leonardo da Vinci, which has been described as the best known, the most visited, the most written about," +
                            " the most sung about, the most parodied work of art in the world.[1] The painting, thought to be a " +
                            "portrait of Lisa Gherardini, the wife of Francesco del Giocondo, is in oil on a white Lombardy poplar " +
                            "panel, and is believed to have been painted between 1503 and 1506.Leonardo may have continued working";
                break;
            case "The Scream":
                InfoText.text = "The Scream (Norwegian: Skrik) is the popular name given to each of four versions of a composition, " +
                            "created as both paintings and pastels, by the Expressionist artist Edvard Munch between 1893 and 1910. " +
                            "The German title Munch gave these works is Der Schrei der Natur (The Scream of Nature). The works show a " +
                            "figure with an agonized expression against a landscape with a tumultuous orange sky. Arthur Lubow has " +
                            "described The Scream as an icon of modern art, a Mona Lisa for our time.[1]";
                break;
            case "The Starry Night":
                InfoText.text = "The Starry Night is an oil on canvas by the Dutch post-impressionist painter Vincent van Gogh. " +
                            "Painted in June 1889, it depicts the view from the east-facing window of his asylum room at " +
                            "Saint-Rémy-de-Provence, just before sunrise, with the addition of an idealized village.[1][2][3] " +
                            "It has been in the permanent collection of the Museum of Modern Art in New York City since 1941, " +
                            "acquired through the Lillie P. Bliss Bequest. It is regarded as among Van Gogh's finest works";
                break;
            case "The Last Supper":
                InfoText.text = "The Last Supper is a late 15th-century mural painting by Leonardo da Vinci in the refectory of the " +
                            "Convent of Santa Maria delle Grazie, Milan. It is one of the world's most famous paintings.[1] " +
                            "The work is presumed to have been commenced around 1495 - 1496 and was commissioned as part of a plan " +
                            "of renovations to the church and its convent buildings by Leonardo's patron Ludovico Sforza, Duke of" +
                            " Milan. The painting represents the scene of The Last Supper of Jesus with his disciples";
                break;
        }
    }
}
