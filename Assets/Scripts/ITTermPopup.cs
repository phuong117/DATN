using UnityEngine;
using TMPro;

public class ITTermPopup : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float moveUpAmount = 50f;
    public float duration = 1f;

    private Vector3 initialPosition;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Setup(string term, Color color)
    {
        text.text = term;
        text.color = color;
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float percent = timer / duration;

        // Move Up
        transform.position = initialPosition + Vector3.up * moveUpAmount * percent;

        // Fade out
        Color c = text.color;
        c.a = Mathf.Lerp(1f, 0f, percent);
        text.color = c;

        // Destroy after
        if (percent >= 1f)
            Destroy(gameObject);
    }
}
