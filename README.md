# in-class-activities
## Devlogs
### W1
"Hello world!"

### W2
RGB variables are floats bacuse they contain decimals. Integers only contain whole numbers, bools only contain true or false, and strings only contain text. The _bounce variable is a integer because you can't bounce something 1.5 times. You can't bounce by a decimal, crossing off floats. _bounce is counting the number of bounces, not whether of not it does bounce for example, so in this case bools don't work. And string is for text not counting. For step 1 of part 2, always end with a semi-colon to finish the line of code. For step 8, define the variable by giving it a type like float. These are the basic grammar and puncuation of code and how the computer can read and execute them.

### W3
Table #12. Input is players dialogue and output is character’s response. Classes are like instruction manuals. The Components are like the different pieces you are provided to use to build something. The member variables are like the unique traits of the pieces you are given (the components) like size and shape of a screw. The methods are like the uses of the pieces (components) like what the different type of screws are used for. The ball gets extremely bright when it reaches a certain speed.

### W4
Table #12 Devlog Prompt. The variable _isGrounded’s value is set to equal true. Bool is the data type stored in the variable _isGrounded. The variable, its data type, and value, are stored in the keyword “private” to indicate that the variable can only be used by the CatW4 Class. Line 28 is an if statement describing something happening if the space key is pressed down and the variable _isGrounded is true. Line 32 is a line of code setting the value of the _isGrounded variable equal to false. My team added Rigidbodies to the Cat and the Soccer Ball and checked the IsTrigger box on the Goal. We want the cat and the ball to hit each other and react accordingly. So we add the rigidbodies to them to simulate physics. We want the ball to go through the goal so we check the IsTrigger box so that it doesn't simulate physics and collide with the ball or the cat. The first time my Cat was phasing through the ball. My teammate kindly reminded me that I forgot to add a rigid body to it. The second time my cat slowly floated up and kept rotating without stopping after hitting the ball. My teammate kindly reminded me to checkmark the constraints.

### W5
My question for activity 1 was what does the Vector3(1, 1, 1) do? One of my table memebers told me that it moves something diagonally up or down. The plan me and my partner came up with was to finish CatW5 to make it move, copy it to DeerW5, figure out what to change, delete what is inside and make update() to start(), make deer walk, figure out nav mesh, get components in inspector, and look for where set destinantion goes. The class will include one main member variable: a Transform named _destination. This field holds the target location the deer should move toward and will be marked with the [SerializeField] attribute so it can be assigned in the Unity Editor. The only required method is Unity’s built-in Start() method, which runs once at the beginning of the game. In Start(), the script retrieves the deer’s NavMeshAgent component and calls SetDestination() using _destination.position, causing the deer to start moving toward the target as soon as the game begins.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 