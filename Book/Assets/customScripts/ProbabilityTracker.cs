using UnityEngine;

public class ProbabilityTracker
{
    private int leftHandLeftUp = 0;
    private int leftHandRightUp = 0;
    private int leftHandRightDown = 0;
    private int leftHandLeftDown = 0;
    private int rightHandLeftUp = 0;
    private int rightHandRightUp = 0;
    private int rightHandRightDown = 0;
    private int rightHandLeftDown = 0;
    private int circleMovement = 0;

    public int getCircleMovement() {
        return circleMovement;
    }
    public void decreaseCircleMovement() {
        circleMovement--;
    }

    public void increaseCircleMovement() {
        circleMovement++;
    }

    public void nullLeftHand()
    {
        leftHandLeftUp = 0;
        leftHandRightUp = 0;
        leftHandRightDown = 0;
        leftHandLeftDown = 0;
    }

    public void nullRightHand()
    {
        rightHandLeftUp = 0;
        rightHandRightUp = 0;
        rightHandRightDown = 0;
        rightHandLeftDown = 0;
    }

    //increase
    public void increaseLeftHandLeftUp()
    {
        leftHandLeftUp++;
    }
    public void increaseRightHandLeftUp()
    {
        rightHandLeftUp++;
    }
    public void increaseLeftHandRightUp()
    {
        leftHandRightUp++;
    }
    public void increaseRightHandRightUp()
    {
        rightHandRightUp++;
    }
    public void increaseLeftHandRightDown()
    {
        leftHandRightDown++;
    }
    public void increaseRightHandRightDown()
    {
        rightHandRightDown++;
    }
    public void increaseLeftHandLeftDown()
    {
        leftHandLeftDown++;
    }
    public void increaseRightHandLeftDown()
    {
        rightHandLeftDown++;
    }
    //decrease
    public void decreaseLeftHandLeftUp()
    {
        leftHandLeftUp--;
    }
    public void decreaseRightHandLeftUp()
    {
        rightHandLeftUp--;
    }
    public void decreaseLeftHandRightUp()
    {
        leftHandRightUp--;
    }
    public void decreaseRightHandRightUp()
    {
        rightHandRightUp--;
    }
    public void decreaseLeftHandRightDown()
    {
        leftHandRightDown--;
    }
    public void decreaseRightHandRightDown()
    {
        rightHandRightDown--;
    }
    public void decreaseLeftHandLeftDown()
    {
        leftHandLeftDown--;
    }
    public void decreaseRightHandLeftDown()
    {
        rightHandLeftDown--;
    }



    //setters
    public void setLeftHandLeftUp(int leftHandLeftUp)
    {
        this.leftHandLeftUp = leftHandLeftUp;

    }
    public void setLeftHandRightUp(int leftHandRightUp)
    {
        this.leftHandRightUp = leftHandRightUp;

    }
    public void setLeftHandRightDown(int leftHandRightDown)
    {
        this.leftHandRightDown = leftHandRightDown;

    }
    public void setLeftHandLeftDown(int leftHandLeftDown)
    {
        this.leftHandLeftDown = leftHandLeftDown;

    }


    public void setRightHandLeftUp(int rightHandLeftUp)
    {
        this.rightHandLeftUp = rightHandLeftUp;

    }
    public void setRightHandRightUp(int rightHandRightUp)
    {
        this.rightHandRightUp = rightHandRightUp;

    }
    public void setRightHandRightDown(int rightHandRightDown)
    {
        this.rightHandRightDown = rightHandRightDown;

    }
    public void setRightHandLeftDown(int rightHandLeftDown)
    {
        this.rightHandLeftDown = rightHandLeftDown;

    }


    //getters
    public int getLeftHandLeftUp()
    {
        return leftHandLeftUp;
    }
    public int getLeftHandRightUp()
    {
        return leftHandRightUp;
    }
    public int getLeftHandRightDown()
    {
        return leftHandRightDown;
    }
    public int getLeftHandLeftDown()
    {
        return leftHandLeftDown;
    }

    public int getRightHandLeftUp()
    {
        return rightHandLeftUp;
    }
    public int getRightHandRightUp()
    {
        return rightHandRightUp;
    }
    public int getRightHandRightDown()
    {
        return rightHandRightDown;
    }
    public int getRightHandLeftDown()
    {
        return rightHandLeftDown;
    }
}