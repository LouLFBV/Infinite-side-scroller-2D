using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [Header("Jump Settings")]
    [SerializeField] private float jumpForce = 1f;
    [SerializeField] private LayerMask groundLayer; 
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private AudioSource jumpSound;


    [Header("Score Settings")]
    [SerializeField] private TextMeshProUGUI scoreTxt;
    private int _score;
    private int _jumpNumber;


    private Rigidbody2D _rb;
    private Animator _animator;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isGrounded = IsGrounded();
        float verticalVelocity = _rb.linearVelocity.y;

        if ((isGrounded || _jumpNumber < 2) && Input.anyKeyDown && (!Input.GetKeyDown(KeyCode.Escape) && !Input.GetMouseButtonDown(0)))
        {
            if (!isGrounded)
            {
                _jumpNumber++;
            }
            else
            {
                _jumpNumber = 1; 
            }
            jumpSound.PlayOneShot(jumpSound.clip);
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, 0f);
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        _animator.SetBool("IsGrounded", isGrounded);
        _animator.SetFloat("VerticalVelocity", verticalVelocity);
    }
    private bool IsGrounded()
    {
        ContactFilter2D filter = new ContactFilter2D();
        filter.SetLayerMask(groundLayer);
        filter.useTriggers = false; 

        Collider2D[] results = new Collider2D[1];
        int count = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, filter, results);

        return count > 0;
    }
    #region Score
    public void AddScore(int points)
    {
        _score += points;
        scoreTxt.text = "Score : " + _score;
    }
    public int GetScore()
    {
        return _score;
    }
    #endregion
}
