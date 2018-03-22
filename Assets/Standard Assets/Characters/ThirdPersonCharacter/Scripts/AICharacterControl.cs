using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target;                                    // target to aim for
	      public Animator anim;
        public int attackDistance;

        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();
	          anim = GetComponent<Animator>();


	        agent.updateRotation = false;
	        agent.updatePosition = true;
          target = GameObject.FindGameObjectWithTag("Player").transform;

        }


        private void Update()
        {
            if (target != null)
            {
                agent.SetDestination(target.position);
                if (agent.remainingDistance <= attackDistance)
                {

                    if (agent.remainingDistance > agent.stoppingDistance)
                    {
                        character.Move(agent.desiredVelocity, false, false);
        		            anim.SetBool("isAttacking", false);
                    }

                    else if (anim.GetCurrentAnimatorStateInfo (0).IsTag("attack")== false)
                    {
                        character.Move(Vector3.zero, false, false);
        		            anim.SetBool("isAttacking", true);
                    }
                  }
                else
                {
                  character.Move(Vector3.zero, false, false);
                  anim.SetBool("isAttacking", false);
                }
                }
}



        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
