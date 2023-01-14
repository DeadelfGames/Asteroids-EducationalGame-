using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Sprite[] sprites;

    public float size = 1.0f;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;
    private Rigidbody2D _rigidbody;
    private SpriteRenderer _spriteREnderer;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteREnderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _spriteREnderer.sprite = sprites[Random.Range(0, sprites.Length)];
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);

        this.transform.localScale = Vector3.one * this.size;
        _rigidbody.mass = this.size;
    }

}
