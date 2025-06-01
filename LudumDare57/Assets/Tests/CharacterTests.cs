using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using InputActionsManagerSystem;

public class CharacterTests : InputTestFixture
{
    GameObject character = Resources.Load<GameObject>("Character");
    Keyboard keyboard;

    public override void Setup()
    {
        SceneManager.LoadScene("Scenes/SimpleTesting");
        base.Setup();
        keyboard = InputSystem.AddDevice<Keyboard>();

        var mouse = InputSystem.AddDevice<Mouse>();
        Press(mouse.rightButton);
        Release(mouse.rightButton); ;
    }

    [Test]
    public void TestPlayerInstantiation()
    {
        GameObject characterInstance = GameObject.Instantiate(character, Vector3.zero, Quaternion.identity);
        Assert.That(characterInstance, !Is.Null);
    }

    [UnityTest]
    public IEnumerator TestPlayerMovement()
    {
        GameObject characterInstance = GameObject.Instantiate(character, Vector3.zero, Quaternion.identity);
        characterInstance.GetComponentInChildren<IInputActionsManager>().EnableMovementInput();

        Press(keyboard.wKey);
        yield return new WaitForSeconds(1.0f);
        Release(keyboard.wKey);
        Assert.That(characterInstance.transform.position.y, Is.GreaterThan(1.0f));

        Press(keyboard.dKey);
        yield return new WaitForSeconds(1.0f);
        Release(keyboard.dKey);
        Assert.That(characterInstance.transform.position.x, Is.GreaterThan(1.0f));
    }
}
