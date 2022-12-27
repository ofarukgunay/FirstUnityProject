using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI _text;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _text.text = score.totalScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Elmas"))
        {
            _audio.Play();
            Destroy(other.gameObject);
            score.totalScore++;
            _text.text = score.totalScore.ToString();
        }
    }
}
