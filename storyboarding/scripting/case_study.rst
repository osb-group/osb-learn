==========
Case Study
==========

Welcome Back, Hello World!
==========================

.. code-block:: c
    :linenos:
    :caption: The completed storyboard segment. Congrats! You earned it.
    :name: Welcome to Storyboarding snippet

    [Events]
    //Background and Video events
    //Storyboard Layer 0 (Background)
    Sprite,Background,Centre,"SB\pixel.png",320,240
     V,19,3799,4579,854,0,854,480
     C,0,3799,16267,41,47,54
     V,18,14709,16267,854,480,854,0
    Sprite,Background,Centre,"SB\blur.png",120,240
     F,0,3799,6916,0.5
     S,2,3799,6916,0,5
     C,0,3799,9254,32,164,243
     P,0,3799,9254,A
     F,0,6916,9254,0.5,0
    Sprite,Background,Centre,"SB\blur.png",520,240
     F,0,3799,6916,0.5
     S,2,3799,6916,0,5
     C,0,3799,9254,255,112,166
     P,0,3799,9254,A
     F,0,6916,9254,0.5,0
    //Storyboard Layer 1 (Fail)
    //Storyboard Layer 2 (Pass)
    //Storyboard Layer 3 (Foreground)
    Sprite,Foreground,Centre,"SB\arrow.png",-80,180
     M,12,3799,5338,-157,180,800,180
     C,0,3799,5338,32,164,243
    Sprite,Foreground,Centre,"SB\arrow.png",800,300
     M,12,3799,5338,800,300,-157,300
     C,0,3799,5338,255,112,166
     P,0,4799,5338,H
    Sprite,Foreground,CentreLeft,"SB\pixel.png",-107,180
     V,12,3799,5338,0,2,854,2
     C,0,3799,9254,32,164,243
     V,30,5338,6137,854,2,854,50
    Sprite,Foreground,CentreRight,"SB\pixel.png",747,300
     V,12,3799,5338,0,2,854,2
     C,0,3799,9254,255,112,166
     V,30,6137,6916,854,2,854,50
    Sprite,Foreground,Centre,"SB\welcome_to.png",320,180
     V,30,5338,6137,1,0,1,1
     V,0,9254,,1,1
    Sprite,Foreground,Centre,"SB\storyboarding.png",320,300
     V,30,6137,6916,1,0,1,1
     V,0,9254,,1,1
    Sprite,Foreground,CentreRight,"SB\pixel.png",320,240
     C,0,3799,10033,32,164,243
     V,29,8475,9254,0,480,427,480
    Sprite,Foreground,CentreLeft,"SB\pixel.png",320,240
     C,0,3799,10033,255,112,166
     V,29,8475,9254,0,480,427,480
    Sprite,Foreground,Centre,"SB\circle.png",320,240
     S,2,9254,10033,0,36
     C,0,9254,10033,41,47,54
    //Storyboard Sound Samples
