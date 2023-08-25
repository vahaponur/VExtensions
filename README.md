# VExtensions Unity Library Documentation

Welcome to the documentation for **VExtensions**, a Unity extension 
library that provides useful and convenient extension methods for various 
Unity classes. This library aims to enhance your workflow by offering 
additional functionality when working with common Unity components. 

## Table of Contents

1. [AnimatorExtensions](#animatorextensions)
2. [AudioExtensions](#audioextensions)
3. [GameObjectExtensions](#gameobjectextensions)
4. [NavMeshAgentExtensions](#navmeshagentextensions)
5. [ParticleExtensions](#particleextensions)
6. [SceneManagerAdapter](#scenemanageradapter)
7. [TransformExtensions](#transformextensions)

## How to Use

You can easily integrate **VExtensions** into your Unity projects by 
following these steps:

1. **Download:** Download the latest release of the **VExtensions** 
library from the [GitHub 
repository](https://github.com/vahaponur/vextensions).

2. **Import to Unity:**

    - **Option 1:** Copy the relevant script files (e.g., 
`AnimatorExtensions.cs`, `AudioExtensions.cs`, etc.) into your project's 
`Assets` folder or any of its subdirectories.
    
    - **Option 2:** Create a separate folder in your project's `Assets` 
directory, e.g., `VExtensions`, and copy all the script files into this 
folder. This helps keep your project organized.

3. **Usage:** After importing the script files, you can use the extension 
methods provided by each class in your C# scripts that are part of your 
Unity project.

## AnimatorExtensions

This class contains extension methods for the `Animator` class.

- **TriggerAll:** Triggers a specific animation state by name on an array 
of `Animator` objects.
  
- **SetBoolAll:** Sets a boolean parameter on an array of `Animator` 
objects.

## AudioExtensions

This class contains extension methods for the `AudioSource` class.

- **PlayWithLogic:** Plays the audio source if it is not already playing.
  
- **PlayOnGetKey:** Plays the audio source while a specific key is being 
pressed and stops it otherwise.
  
- **PlayWithLogic (overload):** Plays a specific audio clip if the audio 
source is not already playing.
  
- **PlayOneShotWithLogic:** Plays a specific audio clip using 
`PlayOneShot` if the audio source is not already playing.
  
- **PlayOnGetKey (overload):** Plays a specific audio clip while a 
specific key is being pressed and stops it otherwise.

## GameObjectExtensions

This class contains extension methods for the `GameObject` class.

- **EnableAll:** Enables all game objects in an array or list by setting 
their `SetActive` property to true.
  
- **DisableAll:** Disables all game objects in an array or list by setting 
their `SetActive` property to false.
  
- **GetComponentAll (two overloads):** Retrieves a specific component from 
all game objects in an array or list.

## NavMeshAgentExtensions

This class contains extension methods for the `NavMeshAgent` class.

- **SetDestinationWithLogic:** Sets the destination of a `NavMeshAgent` if 
it doesn't have a path already.

## ParticleExtensions

This class contains extension methods for the `ParticleSystem` class.

- **PlayWithLogic:** Plays the particle system if it is not already 
playing.
  
- **PlayOnGetKey:** Plays the particle system while a specific key is 
being pressed and stops it otherwise.
  
- **CloseAll (three overloads):** Disables all particle systems in a 
stack, list, or array by setting their game object's `SetActive` property 
to false.
  
- **EnableAll (three overloads):** Enables all particle systems in a 
stack, list, or array by setting their game object's `SetActive` property 
to true.

## SceneManagerAdapter

This class contains extension methods related to scene management using 
`SceneManager`.

- **LoadFirstScene:** Loads the first scene in the build settings 
asynchronously.
  
- **LoadCurrentScene:** Loads the current scene asynchronously.
  
- **LoadSceneAsync (two overloads):** Loads a specific scene by name or 
index in the build settings asynchronously.
  
- **ReloadLevel:** Reloads the current level asynchronously.
  
- **LoadNextLevel:** Loads the next level in the build settings 
asynchronously.
  
- **ReloadSceneAfter:** Reloads the current scene after a specified delay.

## TransformExtensions

This class contains extension methods for the `Transform` class.

- **FindChildWithTag:** Finds a child transform with a specific tag and 
returns it.
  
- **GetChildTransforms (two overloads):** Returns an array or list of 
child transforms of a transform.
  
- **GetChildGameObjects (two overloads):** Returns an array or list of 
child game objects of a transform.

These extension methods are designed to streamline your development 
process and make working with Unity components more efficient.

For any questions, suggestions, or issues, please feel free to contact us 
or contribute on the [GitHub 
repository](https://github.com/vahaponur/vextensions).

---


