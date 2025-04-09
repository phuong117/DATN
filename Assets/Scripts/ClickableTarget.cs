using UnityEngine;

public class ClickableTarget : MonoBehaviour
{
    public GameObject popupPrefab;
    public string[] terms = {
        "HTTP", "REST", "DNS", "IP", "TCP", "JWT", "SQL", "NoSQL", "OOP", "CI/CD", "Agile", "Cloud", "Bugs","DevOps","OOP","IDE","SDK"
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Vector3 spawnPosition = Camera.main.WorldToScreenPoint(transform.position);
        GameObject canvas = GameObject.Find("Canvas");

        GameObject popup = Instantiate(popupPrefab, canvas.transform);
        popup.transform.position = spawnPosition;

        string randomTerm = terms[Random.Range(0, terms.Length)];
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        popup.GetComponent<ITTermPopup>().Setup(randomTerm, randomColor);
    }
}
