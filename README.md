# UnityInputSystem
The scripts I use in my 2D Unity project for easier input management (May work in 3D as well but not tested). Uses a scriptable class for easy button set up and a Controller class to obtain input info for other classes to use.


#### InputAction
This is an enum found in the InputData file and is used instead of KeyCode if you were to use Unity's Input class. This enum is mapped to a KeyCode and used to store InputData in the InputContainerClass.

#### InputData
This class is found in the InputData file and stores the data about button presses such as if the key was held down, if the key is currently down, and if the key was pressed this frame. This data is set using the InputContainer class.

#### InputContainer
This class, found in the file with the same name, stores all data in a dictionary with InputAction as the key. The class provides methods for obtaining data for each action and for setting the data for each action as well as storing a list of previous inputs and locking inputs. This class is ment to be used by a Controller class that sets InputData based on its needs.

#### Controller
This is an abstract class found in the ControllerBase file and is ment to be an Interface for other classes to use to store controllers in. Controllers are ment to provide Input data for other classes to use so that they may execute actions based on input conditions. Controller is abstract to allow for different types of controllers to be made. My Player ControllerScript is just a Controller that takes input from the user but others can be used to act as AI providing their own input. this is set up this way so that Controllers are interchangeable allowing for an AI Controller to be switched with a player Controller.

#### ScriptableInputMap
This is a scriptable class that is used by PlayerControllerScript to map inputs to InputActions and to tell the class how the input should be handled.

#### PlayerControllerScript
This class primarilly sets InputData in its InputContainer using Unity's Input.GetKeyUp and Input.GetKeyDown functions. Using the ScriptableInputMap it determins how the input should be handled, if it should be checked for being held down or if it needs any modifier keys to be pressed as well.
