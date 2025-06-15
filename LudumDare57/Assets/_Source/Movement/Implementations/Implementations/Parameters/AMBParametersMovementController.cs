using UnityEngine;

namespace MovementSystem.Implementations.MB.Parameters
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class AMBParametersMovementController : AMBMovementController
    {
        [SerializeField] private Animator animator;

        private Rigidbody2D _rigidbody;

        private Vector2 _targetDirection;
        private float _targetAngle;

        private int _animatorSwimmingHash;

        protected abstract IMovementParameters Parameters { get; }

        public override Vector2 TargetVelocity { get { return _targetDirection * Parameters.Speed; } }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _animatorSwimmingHash = Animator.StringToHash("IsSwimming");
        }

        private void FixedUpdate()
        {
            if (TargetVelocity == Vector2.zero)
                if (_rigidbody.velocity != Vector2.zero)
                    _rigidbody.velocity = Vector2.MoveTowards(_rigidbody.velocity, Vector2.zero, Parameters.Deceleration * Time.fixedDeltaTime);
            else
            {
                _rigidbody.rotation = Mathf.MoveTowardsAngle(_rigidbody.rotation, _targetAngle, 200.0f * Time.fixedDeltaTime);

                if (_rigidbody.velocity != TargetVelocity)
                    _rigidbody.velocity = Vector2.MoveTowards(_rigidbody.velocity, TargetVelocity, Parameters.Acceleration * Time.fixedDeltaTime);
            }
        }

        public override void Move(Vector2 direction)
        {
            _targetDirection = direction;
            _targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90.0f;

            if (direction.x < -0.01f)
                transform.localScale = new(-1.0f, 1.0f, 1.0f);
            else if (direction.x > 0.01f)
                transform.localScale = new(1.0f, 1.0f, 1.0f);

            if (direction.magnitude > 0f)
                animator.SetBool(_animatorSwimmingHash, true);
            else
                animator.SetBool(_animatorSwimmingHash, false);
        }
    }
}
